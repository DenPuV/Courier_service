using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Courier_service.Models;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using MudBlazor;
using Courier_service.Services.LocationService;
using System.Net.Http;
using BlazorLeaflet.Models;

namespace Courier_service.Pages
{
    public class CourierOrdersCode : ComponentBase
    {
        [Inject]
        NavigationManager NavigationManager { get; set; }
        [Inject]
        AuthenticationStateProvider _authenticationStateProvider { get; set; }
        [Inject]
        UserManager<IdentityUser> _userManager { get; set; }
        [Inject]
        protected DatabaseService _databaseService { get; set; }
        [Inject]
        protected IHttpClientFactory _clientFactory { get; set; }
        public LocationProvider _locationProvider { get; set; }
        public MapController _mapController { get; set; }
        public IdentityUser user { get; set; }
        public Courier courier { get; set; }
        public Order order { get; set; }
        public Delivery delivery { get; set; }
        public List<Order> Orders { get; set; }
        public string route { get; set; } = String.Empty;
        public bool downloading { get; set; } = true;
        public bool dataLoaded { get; set; } = false;

        protected override async Task OnInitializedAsync()
        {
            _locationProvider = new LocationProvider(_clientFactory);

            var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
            var idUser = authState.User;

            if (idUser.Identity.IsAuthenticated)
            {
                user = await _userManager.FindByNameAsync(idUser.Identity.Name);
                var _courier = (from cor in _databaseService._dbcontext.Couriers
                                where cor.AspUserId == user.Id
                                select cor);
                if (_courier.Count() > 0)
                { 
                    courier = _courier.First<Courier>();
                    GetOrdersData();
                }
                else ShowErrorSnackBar("You are not a courier!");
            }
            else
            {
                ShowErrorSnackBar("You are not authorized!");
            }
            downloading = false;
            dataLoaded = true;
            StateHasChanged();
        }

        public void GetOrdersData()
        {
            var _delivery = from del in _databaseService._dbcontext.Deliveries
                           join ord in _databaseService._dbcontext.Orders on del.OrderId equals ord.Id
                           where del.CourierId == courier.Id && (ord.Status == "return" || ord.Status == "delivering")
                           select new { Order = ord, Delivery = del };

            if (_delivery.Count() > 0)
            {
                delivery = _delivery.First().Delivery;
                order = _delivery.First().Order;
                delivery.Order = order;
                order = LoadOrder(order);
                order.Comments = _databaseService.GetOrderComments(order.Id);
                try
                {
                    route = LocationProvider.makePath(
                        _locationProvider.GetRoute(order.Route.StartCoordinates, order.Route.FinishCoordinates));
                }
                catch { ShowErrorSnackBar("Ошибка составления маршрута!"); }
            }
            else 
            {
                Orders = (from oc in _databaseService._dbcontext.OrderCouriers
                          join o in _databaseService._dbcontext.Orders on oc.OrderId equals o.Id
                          where oc.CourierId == courier.Id && 
                          !(o.Status == "delivered" || o.Status == "reversed" || o.Status == "cancelled")
                          select o).ToList<Order>();
                if (Orders.Count == 0)
                {
                    if(_databaseService.BindNewOrderToCourier(courier)) GetOrdersData();
                }
                else
                {
                    foreach (Order ord in Orders)
                    {
                        ord.Route = (from route in _databaseService._dbcontext.Routes
                                     where route.Id == ord.RouteId
                                     select route).First<Route>();
                    }
                }
            }
            InvokeAsync(() => StateHasChanged());
        }
        public Order LoadOrder(Order o)
        {
            o.Package = (from package in _databaseService._dbcontext.Packages
                         where o.PackageId == package.Id
                         select package).First<Package>();

            o.Contact = (from contact in _databaseService._dbcontext.Contacts
                         where o.ContactId == contact.Id
                         select contact).First<Contact>();

            o.Route = (from route in _databaseService._dbcontext.Routes
                       where o.RouteId == route.Id
                       select route).First<Route>();

            o.Comments = (from comment in _databaseService._dbcontext.Comments
                          where comment.OrderId == o.Id
                          select comment).ToList<Comment>();

            return o;
        }


        public void StartDelivering(Order order)
        {
            delivery = _databaseService.StartDelivery( order, courier);
            if (delivery != null)
            {
                this.order = LoadOrder(order);
                ShowSuccessSnackBar("Доставка началась!");
                try
                {
                    route = LocationProvider.makePath(
                        _locationProvider.GetRoute(order.Route.StartCoordinates, order.Route.FinishCoordinates));
                }
                catch { ShowErrorSnackBar("Ошибка составления маршрута!"); }
            }
            else
            {
                this.order = null;
                ShowErrorSnackBar("Доставка не началась!");
            }
            StateHasChanged();
        }
        public void CompleteDelivery()
        {
            try
            {
                
                _databaseService.CompleteDelivery(delivery);
                order = null;
                delivery = null;
                ShowSuccessSnackBar("Доставка завершена!");
            }
            catch
            {
                ShowErrorSnackBar("Невозможно завершить доставку!");
            }
            GetOrdersData();
        }

        public void ShowRoute(string route)
        {
            _mapController.deleteAllMarkers();
            _mapController.deleteAllPolylines();
            LatLng sc = LocationDistance.ParseLatLng(order.Route.StartCoordinates);
            LatLng fc = LocationDistance.ParseLatLng(order.Route.FinishCoordinates);
            if (sc != null && fc != null)
            {
                _mapController.AddMarker(new Marker(sc) { Popup = new Popup() { Content = order.Route.StartName } });
                _mapController.AddMarker(new Marker(fc) { Popup = new Popup() { Content = order.Route.FinishName } }, true);
                _mapController.AddPathAndBound(route,
                    $"{order.Route.StartName}<br>" +
                        $"<span class='glyphicon glyphicon - name'>" +
                        $"</span><br>{order.Route.FinishName}");

            }
        }

        [Inject]
        ISnackbar snackbar { get; set; }
        public void ShowErrorSnackBar(string message)
        {
            snackbar.Add(message, Severity.Error);
        }
        public void ShowSuccessSnackBar(string message)
        {
            snackbar.Add(message, Severity.Success);
        }
    }
}
