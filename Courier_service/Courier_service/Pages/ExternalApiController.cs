using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Courier_service.Models;
using Courier_service.Services.LocationService;
using System.Net.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Courier_service.Pages
{
    [Route("api/orders")]
    [ApiController]
    public class ExternalApiController : ControllerBase
    {
        DatabaseService _ds = new DatabaseService();
        HttpClient _client;
        LocationProvider _lp;

        [HttpGet]
        public List<jsonOrder> Get()
        {
            int clientId = Convert.ToInt32(ControllerContext.HttpContext.Request.Headers["id"]);
            List<jsonOrder> ordersList = new List<jsonOrder>();

            var orders = from o in _ds.GetOrders(clientId)
                         join p in _ds._dbcontext.Packages on o.PackageId equals p.Id
                         join c in _ds._dbcontext.Contacts on o.ContactId equals c.Id
                         join r in _ds._dbcontext.Routes on o.RouteId equals r.Id
                         where o.ClientId == clientId
                         select (o, p, c, r);

            foreach (var val in orders)
            {
                ordersList.Add(new jsonOrder()
                {
                    orderid = val.o.Id,
                    orderstatus = val.o.Status,
                    startcoordinates = val.r.StartCoordinates,
                    startname = val.r.StartName,
                    finishcoordinates = val.r.FinishCoordinates,
                    finishname = val.r.FinishName,
                    description = val.p.Description,
                    weightstr = val.p.Weight,
                    fname = val.c.FName,
                    sname = val.c.SName,
                    patronymic = val.c.Patronymic,
                    phone = val.c.Phone
                });
            }

            return ordersList;
        }

        // GET api/<ExternalApiController>/5
        [HttpGet("{id}")]
        public jsonOrder Get(int id)
        {
            int clientId = Convert.ToInt32(ControllerContext.HttpContext.Request.Headers["id"]);
            jsonOrder order = null;

            var orders = from o in _ds.GetOrders(clientId)
                         join p in _ds._dbcontext.Packages on o.PackageId equals p.Id
                         join c in _ds._dbcontext.Contacts on o.ContactId equals c.Id
                         join r in _ds._dbcontext.Routes on o.RouteId equals r.Id
                         where o.ClientId == clientId && o.Id == id  
                         select (o, p, c, r);

            foreach (var val in orders)
            {
                order = new jsonOrder()
                {
                    orderid = val.o.Id,
                    orderstatus = val.o.Status,
                    startcoordinates = val.r.StartCoordinates,
                    startname = val.r.StartName,
                    finishcoordinates = val.r.FinishCoordinates,
                    finishname = val.r.FinishName,
                    description = val.p.Description,
                    weightstr = val.p.Weight,
                    fname = val.c.FName,
                    sname = val.c.SName,
                    patronymic = val.c.Patronymic,
                    phone = val.c.Phone
                };
            }

            return order;
        }

        //POST api/<ExternalApiController>
        /* localhost:5000/api/orders?startcoordinates=[58.57800,49.62929]&finishcoordinates=[58.59380,49.64894]&fname=Антон&sname=Антонов&patronymic=Олегович&phone=5748674&description=Ананас&weight=0.1*/
        [HttpPost]
        public StatusCodeResult Post(string startcoordinates, string finishcoordinates, string sname, string fname, string patronymic, string phone,
            string description, double _weight)
        {
            jsonOrder results = new jsonOrder()
            {
                startcoordinates = startcoordinates,
                finishcoordinates = finishcoordinates,
                fname = fname,
                sname = sname,
                patronymic = patronymic,
                phone = phone,
                weight = _weight,
                description = description
            };
            _client = new HttpClient();
            _lp = new LocationProvider(_client);

            int clientId = Convert.ToInt32(ControllerContext.HttpContext.Request.Headers["id"]);
            
            double price;
            Package package = new Package();
            Route route = new Route();
            Contact contact = new Contact();

            try
            {

                route.StartCoordinates = results.startcoordinates;
                route.FinishCoordinates = results.finishcoordinates;
                route.StartAddress = _lp.GetAddress(route.StartCoordinates);
                route.FinishAddress = _lp.GetAddress(route.FinishCoordinates);
                route.StartName = route.StartAddress.display_name;
                route.FinishName = route.FinishAddress.display_name;
                double distance = LocationDistance.DistanceBetweenPlaces(route.StartCoordinates, route.FinishCoordinates);

                package.Description = results.description;
                double weight = results.weight;
                if (weight < 1) { package.Weight = "< 1 kg"; price = distance * 0.1; }
                else if (weight >= 1 && weight < 5) { package.Weight = "1 < 5 kg"; price = distance * 0.2; }
                else if (weight >= 5 && weight < 10) { package.Weight = "5 < 10 kg"; price = distance * 0.3; }
                else if (weight > 10) { package.Weight = "> 10 kg"; price = distance * 0.5; }
                else throw new Exception();

                contact.FName = results.fname;
                contact.SName = results.sname;
                contact.Patronymic = results.patronymic;
                contact.Phone = results.phone;

                _ds.PlaceOrder(package, contact, route, new Client() { Id = clientId }, (decimal)price);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }

        //// PUT api/<ExternalApiController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<ExternalApiController>/5
        [HttpDelete("{id}")]
        public StatusCodeResult Delete(int id)
        {
            Order order = _ds._dbcontext.Find<Order>(id);
            int clientId = Convert.ToInt32(ControllerContext.HttpContext.Request.Headers["id"]);

            if (order != null && order.ClientId == clientId)
            {
                if (order.Status == "accepted" || order.Status == "waiting for delivery")
                {
                    _ds.CancellOrder(order);

                    return Ok();
                }
                else return StatusCode(666);
            }
            else 
            {
                return NotFound();
            }
        }
    }
}
