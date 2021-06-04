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
        public LocationProvider locationProvider { get; set; }
        public MapController _mapController { get; set; }
		public Map _map { get; set; }

        public delegate void Event(string str);
        public event Event WrongAddress;

		public bool mapVisible = false;
        public bool mapReady = false;
        public bool downloading = false;

		public string SendAddress { get; set; }
		public string RecAddress { get; set; } = "";
        public double distance { get; set; } = 0;
        public string price = "";
        public bool invalid { get; set; } = true;

        public async void CalculateDistance()
        {
            if (SendAddress != "" && RecAddress != "")
            {
                downloading = true;
                mapVisible = true;
                
                _mapController.deleteAllMarkers();
                _mapController.deleteAllPolylines();

                await Task.Run(() =>
                {
                    Address sAddr = locationProvider.GetAddress(SendAddress);
                    Address dAddr = locationProvider.GetAddress(RecAddress);

                    if (sAddr != null && dAddr != null)
                    {
                        distance = LocationDistance.DistanceBetweenPlaces(sAddr.GetLatLng(), dAddr.GetLatLng());
                        showPath(sAddr, dAddr);
                        price = (distance * 0.1).ToString("N0");
                    }
                    else
                    {
                        if (sAddr == null)
                        {
                            WrongAddress.Invoke("Адрес отправки не найден!");
                            SendAddress = "";
                        }
                        if (dAddr == null)
                        {
                            WrongAddress.Invoke("Адрес доставки не найден!");
                            RecAddress = "";
                        }
                        mapVisible = false;
                        distance = 0;
                    }
                    downloading = false;
                });
                StateHasChanged();
            }
        }

        public void validate()
        {
			distance = 0;
			invalid = (SendAddress == "" || RecAddress == "");
            InvokeAsync(() => { StateHasChanged(); });
        }

		public void showPath(Address sAddr, Address dAddr)
		{
			_mapController.AddMarker(sAddr);
			_mapController.AddMarker(dAddr, true);
            _mapController.AddPathAndBound($"[[{sAddr.GetLatLng().Lat.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))}" +
                $",{sAddr.GetLatLng().Lng.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))}]" +
                $",[{dAddr.GetLatLng().Lat.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))}" +
                $",{dAddr.GetLatLng().Lng.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))}]]", "Расстояние: " + distance.ToString("N0") + " м.");
		}
    }
}
