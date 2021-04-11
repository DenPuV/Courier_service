using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Courier_service.Services.LocationService;
using System.Net.Http;
using BlazorLeaflet;
using Microsoft.JSInterop;

namespace Courier_service.Components
{
    public class Calculator : ComponentBase
    {
		[Inject]
		private IJSRuntime _jsRuntime { get; set; }
		[Inject]
		private IHttpClientFactory _clientFactory { get; set; }
        private LocationProvider locationProvider { get; set; }
        public MapController _mapController { get; set; }
		public Map _map { get; set; }

		public bool mapVisible = false;
        public bool mapReady = false;

		public string SendAddress { get; set; }
		public string RecAddress { get; set; } = "";
        public string distance { get; set; } = "";
        public bool invalid { get; set; } = true;

        protected override void OnInitialized()
        {
            locationProvider = new LocationProvider(_clientFactory);
            _map = new Map(_jsRuntime);
            _map.OnInitialized += () =>
            {
                _mapController = new MapController(_jsRuntime, _clientFactory, _map);
                mapReady = true;
            };
            _map.RaiseOnInitialized();
        }

        public async void CalculateDistance()
        {
            if (SendAddress != "" && RecAddress != "")
            {
                Address sAddr = new Address();
                Address dAddr = new Address();

                await Task.Run(() =>
                {
                    sAddr = locationProvider.GetAddress(SendAddress).Result;
                    dAddr = locationProvider.GetAddress(RecAddress).Result;

                    if (sAddr != null && dAddr != null)
                    {
                        distance = LocationDistance.DistanceBetweenPlaces(sAddr.GetLatLng(), dAddr.GetLatLng()).ToString("N0");

                        showPath(sAddr, dAddr);
                        //_mapController.AddPathAndBound(locationProvider.GetRouteString(sAddr, dAddr).Result);
                        mapVisible = true;

                    }
                    else
                    {
                        mapVisible = false;
                        SendAddress = "";
                        RecAddress = "";
                    }
                });
            }
        }

        public void validate()
        {
			distance = "";
			invalid = (SendAddress == "" || RecAddress == "");
			StateHasChanged();
        }

		public void showPath(Address addr1, Address addr2)
		{
			_mapController.AddMarkerAsync(addr1);
			_mapController.AddMarkerAsync(addr2);
            _mapController.AddPathAndBound($"[[{addr1.GetLatLng().Lat.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))}" +
                $",{addr1.GetLatLng().Lng.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))}]" +
                $",[{addr2.GetLatLng().Lat.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))}" +
                $",{addr2.GetLatLng().Lng.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))}]]", "Distance = " + distance + " m.");
		}
    }
}
