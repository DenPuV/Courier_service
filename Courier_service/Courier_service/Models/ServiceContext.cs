﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Courier_service.Models
{
    public class ServiceContext : DbContext
    {
        public ServiceContext(DbContextOptions<ServiceContext> options):base(options)
        {   
        }
        public ServiceContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=Courier_service;User Id=postgres;Password=230798");
            }
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Courier> Couriers { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<OrderCourier> OrderCouriers { get; set; }
    }

    public class DatabaseService
    {
        public readonly ServiceContext _dbcontext;

        public DatabaseService(ServiceContext _db)
        {
            _dbcontext = _db;
        }

        public DatabaseService()
        {
            _dbcontext = new ServiceContext();
        }
        public List<Client> ClientData()
        {
            try { return _dbcontext.Clients.ToList(); }
            catch { return null; }
        }
        public async Task<List<Client>> ClientDataAsync()
        {
            return await Task.Run(() => ClientData());
        }

        public void AddClient(Client client)
        {
            _dbcontext.Clients.Add(client);
        }
        public Package AddPackage(Package package)
        {
            Package p = _dbcontext.Packages.Add(package).Entity;
            SaveData();
            return p;
        }
        public Contact AddContact(Contact contact)
        {
            Contact c = _dbcontext.Contacts.Add(contact).Entity;
            SaveData();
            return c;
        }
        public Route AddRoute(Route route)
        {
            Route r = _dbcontext.Routes.Add(route).Entity;
            SaveData();
            return r;
        }
        public Delivery AddDelivery(Delivery delivery)
        {
            Delivery d = _dbcontext.Deliveries.Add(delivery).Entity;
            SaveData();
            return d;
        }
        public void PlaceOrder(Package package, Contact contact, Route route, Client client, decimal price )
        {
            package = AddPackage(package);
            contact = AddContact(contact);
            route = AddRoute(route);
            Order order = new Order() {
                Date = DateTime.Now,
                Price = price,
                ClientId = client.Id,
                ContactId = contact.Id,
                PackageId = package.Id,
                RouteId = route.Id,
                Status = "accepted",
                Type = package.Weight
            };
            _dbcontext.Orders.Add(order);
            try
            {
                SaveData();
            }
            catch
            {
                _dbcontext.Orders.Remove(order);
                _dbcontext.Packages.Remove(package);
                _dbcontext.Contacts.Remove(contact);
                _dbcontext.Routes.Remove(route);
                throw new Exception("Cannot commit transaction");
            }
        }
        public void PlaceReverseOrder(Order order)
        {
            if (order.Route != null)
            {
                order.Status = "reversed";
                int courierid = (from del in _dbcontext.Deliveries
                              join ord in _dbcontext.Orders on del.OrderId equals ord.Id
                              where ord.Id == order.Id
                              select del.CourierId).First<int>();
                Courier courier = _dbcontext.Couriers.Find(courierid);
                try
                {
                    Route reverseRoute = new Route()
                    {
                        StartAddress = order.Route.FinishAddress,
                        StartCoordinates = order.Route.FinishCoordinates,
                        StartName = order.Route.FinishName,
                        FinishAddress = order.Route.StartAddress,
                        FinishCoordinates = order.Route.StartCoordinates,
                        FinishName = order.Route.StartName
                    };
                    reverseRoute = AddRoute(reverseRoute);
                    SaveData();
                    Order reverseOrder = new Order()
                    {
                        Date = DateTime.Now,
                        Price = order.Price,
                        ContactId = order.ContactId,
                        Contact = order.Contact,
                        ClientId = order.ClientId,
                        Client = order.Client,
                        RouteId = reverseRoute.Id,
                        Route = reverseRoute,
                        PackageId = order.PackageId,
                        Package = order.Package,
                        Status = "return",
                        Type = order.Type
                    };
                    reverseOrder = _dbcontext.Orders.Add(reverseOrder).Entity;
                    SaveData();
                    _dbcontext.Deliveries.Add(new Delivery(){
                        OrderId = reverseOrder.Id,
                        CourierId = courierid,
                        Date = DateTime.Now
                    });
                    SaveData();
                }
                catch 
                {
                    throw new Exception("Can not reverse order!"); }
            }
            else throw new NullReferenceException("Order route is null!");
        }
        public Order UpdateOrderStatus(Order order, String status)
        {
            Order ord = _dbcontext.Orders.Find(order.Id);
            if (ord != null)
            {
                order.Status = status;
                _dbcontext.Entry<Order>(ord).CurrentValues.SetValues(order);
            }
            SaveData();
            return ord;
        }
        public void SaveData()
        {
            try
            {
            _dbcontext.SaveChanges(); 
            }
            catch(Exception ex) { throw new Exception(ex.Message); }
        }
        public void UpdateClient(Client client) 
        {
                Client cl = _dbcontext.Clients.Find(client.Id);
                if (cl != null)
                {
                    _dbcontext.Entry<Client>(cl).CurrentValues.SetValues(client);
                }
        }
        public Client GetClient(string userId)
        {
            var cl = from c in _dbcontext.Clients
                     where c.AspName == userId
                     select c;

            return (cl.Count() > 0) ? cl.First() : null;
        }
        public Comment AddComment(string str, int orderId)
        {
            Comment comment = new Comment()
            {
                Date = DateTime.Now,
                Content = str,
                OrderId = orderId
            };
            _dbcontext.Comments.Add(comment);
            SaveData();
            return comment;
        }
        public Order CancellOrder(Order order)
        {
            order.Status = "cancelled";
            Order ord = _dbcontext.Orders.Find(order.Id);
            if (ord != null)
            {
                try
                {
                    _dbcontext.Entry<Order>(ord).CurrentValues.SetValues(order);
                    SaveData();
                    return ord;
                }
                catch { throw new Exception("Something went wrong while cancelling order!"); }
            }
            else return null;
        }
        public bool BindNewOrderToCourier(Courier courier)
        {
            var orders = from ord in _dbcontext.Orders
                         where ord.Status == "accepted"
                         select ord;
            if (orders.Count() > 0)
            {
                try
                {
                    _dbcontext.OrderCouriers.Add(new OrderCourier()
                    {
                        OrderId = orders.First<Order>().Id,
                        Order = orders.First<Order>(),
                        CourierId = courier.Id,
                        Courier = courier
                    });
                    UpdateOrderStatus(orders.First<Order>(), "waiting for delivery");
                    SaveData();
                    return true;
                }
                catch
                {
                    return false;
                }

            }
            else return false;
        }
        public Delivery StartDelivery(Order order, Courier courier)
        {
            try
            {
                order = UpdateOrderStatus(order, "delivering");
                Delivery delivery = new Delivery()
                {
                    Date = DateTime.Now,
                    OrderId = order.Id,
                    Order = order,
                    CourierId = courier.Id,
                    Courier = courier
                };
                AddDelivery(delivery);
                return delivery;
            }
            catch 
            {
                return null;
            }
        }
        public void CompleteDelivery(Delivery delivery)
        {
            try
            {
                UpdateOrderStatus(delivery.Order, "delivered");
            }
            catch 
            {
                throw new Exception("Something went wrong while completing delivery");
            }
        }
    }
}
