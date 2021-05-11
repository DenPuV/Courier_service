using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Courier_service.Models;
using Courier_service.Services.LocationService;
using BlazorLeaflet;
using BlazorLeaflet.Models;
using Microsoft.JSInterop;
using System.Net.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Components.Authorization;
using MudBlazor;

namespace Courier_service.Pages
{
    public class NewOrderCode : ComponentBase
    {
        [Inject]
        AuthenticationStateProvider _authenticationStateProvider { get; set; }
        [Inject]
        UserManager<IdentityUser> _userManager { get; set; }
        [Inject]
        NavigationManager _navigationManager { get; set; }
        [Inject]
        public IJSRuntime _jsRuntime { get; set; }
        [Inject]
        public IHttpClientFactory _clientFactory { get; set; }
        [Inject]
        public DatabaseService _databaseService { get; set; }

        public Map _map { get; set; }
        public MapController _mapController { get; set; }

        public IdentityUser user { get; set; }
        public Client client { get; set; }
        public Contact contact { get; set; }
        public Package package { get; set; }
        public Route route { get; set; }
        public double distance { get; set; } = 0;
        public decimal price { get; set; } = 0;

        public bool selfContact { get; set; }
        public bool downloading { get; set; } = true;
        public string selectedWeight { get; set; } = "< 1 kg";
        public string currentWeight { get; set; }

        protected override async Task OnInitializedAsync()
        {

            var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
            var idUser = authState.User;

            if (idUser.Identity.IsAuthenticated)
            {
                user = await _userManager.FindByNameAsync(idUser.Identity.Name);
                client = _databaseService.GetClient(user.Id);
                downloading = false;
            }
            else
            {
                ShowErrorSnackBar("Вы не авторизованы!");
                _navigationManager.NavigateTo("/");
                downloading = false;
            }
        }

        public bool PackageValid()
        {
            package.Weight = currentWeight;
            if (package.Description != null && currentWeight != null) return true;
            else
            {
                ShowErrorSnackBar("Введите все данные о посылке!");
                return false;
            }
        }

        public bool ContactValid()
        {
            if (contact.FName != null && contact.SName != null && contact.Patronymic != null && contact.Phone != null) return true;
            else
            {
                ShowErrorSnackBar("Введите все контактные данные!");
                return false;
            }
        }

        public bool RouteValid()
        {
            if (route.StartAddress != null && route.FinishAddress != null) return true;
            else
            {
                ShowErrorSnackBar("Выберите маршрут!");
                return false;
            }
        }

        public void PlaceOrder()
        {
            if (PackageValid() && ContactValid() && RouteValid() && client != null)
            {
                downloading = true;
                route.StartCoordinates = LocationProvider.makeStringLatlng(route.StartAddress.GetLatLng());
                route.FinishCoordinates = LocationProvider.makeStringLatlng(route.FinishAddress.GetLatLng());
                route.StartName = route.StartAddress.display_name;
                route.FinishName = route.FinishAddress.display_name;
                try
                {
                    _databaseService.PlaceOrder(package, contact, route, client, price);
                    ShowSuccessSnackBar("Заказ успешно составлен!");
                    _navigationManager.NavigateTo("/");
                }
                catch { ShowErrorSnackBar("Что-то пошло не так!"); }
            }
            downloading = false;
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
