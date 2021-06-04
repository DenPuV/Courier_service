using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Courier_service.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace Courier_service.Components
{
    public class OpenOrders : ComponentBase
    {
        private Client Client { get; set; } = null;
        private Courier Courier { get; set; } = null;

        [Inject]
        public DatabaseService _ds { get; set; }
        [Inject]
        AuthenticationStateProvider _authenticationStateProvider { get; set; }
        [Inject]
        UserManager<IdentityUser> _userManager { get; set; }
        public string Message { get; set; } = "";
        public bool CountersLoaded { get; set; } = false;

        protected override async Task OnInitializedAsync()
        {
            var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
            var idUser = authState.User;
            if (idUser.Identity.IsAuthenticated)
            {
                var user = await _userManager.FindByNameAsync(idUser.Identity.Name);
                Client = _ds.GetClient(user.Id);
                if (Client != null)
                {
                    CountOpenOrders();
                    CountersLoaded = true;
                }
                else 
                {
                    Courier = _ds.GetCourier(user.Id);
                    if (Courier != null)
                    {
                        CountAvailableOrders();
                        CountersLoaded = true;
                    }
                }
            }
        }

        [Authorize(Roles = "Client")]
        private void CountOpenOrders()
        {
            var openOrders = from order in _ds._dbcontext.Orders
                             where order.ClientId == this.Client.Id && (order.Status == "accepted" || order.Status == "waiting for delivery")
                             select order;
            int openOrdersCount = openOrders.Count();

            var deliveringOrders = from order in _ds._dbcontext.Orders
                                   where order.ClientId == Client.Id && order.Status == "delivering"
                                   select order;
            int deliveringOrdersCount = deliveringOrders.Count();

            Message = $"Открытых заказов: {openOrdersCount}. Доставляются: {deliveringOrdersCount}.";
        }

        [Authorize(Roles = "Courier")]
        private void CountAvailableOrders()
        {
            var delivery = from courier in _ds._dbcontext.Couriers
                           join del in _ds._dbcontext.Deliveries on courier.Id equals del.CourierId
                           join order in _ds._dbcontext.Orders on del.OrderId equals order.Id
                           where (order.Status == "delivering" || order.Status == "return") && courier.Id == Courier.Id
                           select del;

            if (delivery.Count() > 0) Message = "Вы начали доставку заказа! Перейдите к заказам для завершения.";
            else
            {
                var order = from courier in _ds._dbcontext.Couriers
                               join oc in _ds._dbcontext.OrderCouriers on courier.Id equals oc.CourierId
                               join ord in _ds._dbcontext.Orders on oc.OrderId equals ord.Id
                               where courier.Id == Courier.Id && ord.Status == "waiting for delivery"
                               select ord;
                if (order.Count() > 0) Message = "Заказ ожидает доставки! Перейдите к заказам для начала.";
                else 
                {
                    var orders = from ord in _ds._dbcontext.Orders
                                 where ord.Status == "accepted" || ord.Status == "waiting for delivery"
                                 select ord;
                    if (orders.Count() > 0) Message = $"Доступно заказов: {orders.Count()}. Перейдите к заказам для начала.";
                    else Message = "Сейчас нет открытых заказов!";
                }
            }
        }
    }
}
