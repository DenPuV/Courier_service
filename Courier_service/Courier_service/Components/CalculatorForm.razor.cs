﻿using Microsoft.AspNetCore.Components;
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
        public bool invalid { get; set; } = true;

        public async void CalculateDistance()
        {
            if (SendAddress != "" && RecAddress != "")
            {
                downloading = true;
                mapVisible = true;
                _mapController.deleteAllMarkers();
                _mapController.deleteAllPolylines();
                //Address sAddr = locationProvider.GetAddress(SendAddress).Result; //new Address();
                //Address dAddr = locationProvider.GetAddress(RecAddress).Result; //new Address();

                await Task.Run(() =>
                {
                    //sAddr = locationProvider.GetAddress(SendAddress).Result;
                    //dAddr = locationProvider.GetAddress(RecAddress).Result;
                    Address sAddr = locationProvider.GetAddressAsync("Киров " + SendAddress).Result;
                    Address dAddr = locationProvider.GetAddressAsync("Киров " + RecAddress).Result;

                    if (sAddr != null && dAddr != null)
                    {
                        mapVisible = true;
                        distance = LocationDistance.DistanceBetweenPlaces(sAddr.GetLatLng(), dAddr.GetLatLng());
                        showPath(sAddr, dAddr);
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
                    validate();
                    InvokeAsync(() => { StateHasChanged(); });
                });
            }
        }

        public void validate()
        {
			distance = 0;
			invalid = (SendAddress == "" || RecAddress == "");
            InvokeAsync(() => { StateHasChanged(); });
        }

		public void showPath(Address addr1, Address addr2)
		{
			_mapController.AddMarker(addr1);
			_mapController.AddMarker(addr2);
            _mapController.AddPathAndBound($"[[{addr1.GetLatLng().Lat.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))}" +
                $",{addr1.GetLatLng().Lng.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))}]" +
                $",[{addr2.GetLatLng().Lat.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))}" +
                $",{addr2.GetLatLng().Lng.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))}]]", "Distance = " + distance.ToString("N0") + " m.");
		}
    }
}
