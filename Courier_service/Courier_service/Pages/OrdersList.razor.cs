using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Courier_service.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Components.Authorization;
using MudBlazor;

namespace Courier_service.Pages
{
    public class orderslistcode : ComponentBase
    {
        [Inject]
        AuthenticationStateProvider _authenticationStateProvider { get; set; }
        [Inject]
        UserManager<IdentityUser> _userManager { get; set; }
        [Inject]
        protected DatabaseService _databaseService { get; set; }
        public IdentityUser user { get; set; }
        public Client client { get; set; }
        public bool downloading { get; set; } = true;
        public bool dataLoaded { get; set; } = false;
        public List<Order> orders { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
            var idUser = authState.User;

            if (idUser.Identity.IsAuthenticated)
            {
                user = await _userManager.FindByNameAsync(idUser.Identity.Name);
                client = _databaseService.GetClient(user.Id);
                DownloadLists();
            }
            else
            {
                ShowErrorSnackBar("You are not authorized!");
            }
            downloading = false;
            StateHasChanged();
        }

        public void DownloadLists()
        {
            orders = (from order in _databaseService._dbcontext.Orders
                      where order.ClientId == client.Id
                      orderby order.Id descending
                      select order).ToList<Order>();


            foreach (Order o in orders)
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

                var deliveries = from delivery in _databaseService._dbcontext.Deliveries
                                 where delivery.OrderId == o.Id
                                 select delivery;

                if (deliveries.Count<Delivery>() > 0)
                {
                    o.Delivery = deliveries.First<Delivery>();
                    o.Delivery.Order = o;
                    o.Delivery.Courier = (from courier in _databaseService._dbcontext.Couriers
                                          where o.Delivery.CourierId == courier.Id
                                          select courier).First<Courier>();
                }

                o.Client = client;
            }

            dataLoaded = true;
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
