using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using BlazorLeaflet;
using BlazorLeaflet.Models;
using BlazorLeaflet.Models.Events;
using BrowserInterop.Extensions;
using BrowserInterop.Geolocation;
using BlazorLeaflet.Utils;

namespace Courier_service.Services.LocationService
{
    public class MapController
    {

        private readonly IJSRuntime _jsRuntime;
        private readonly IHttpClientFactory _clientFactory;
        private WindowNavigatorGeolocation geolocationWrapper;
        private GeolocationResult currentPosition;
        private Map _map;
        private Address currentAddress = null;
        private LocationProvider locationProvider;

        private List<Marker> markers { get; set; } = new List<Marker>();
        public delegate void Event();
        private List<string> polyLines = new List<string>();

        public MapController(IJSRuntime js, IHttpClientFactory cl, Map map)
        {
            _jsRuntime = js;
            _clientFactory = cl;
            _map = map;
            initializeLayers();
        }

        private void initializeLayers()
        {
            _map.AddLayer(new TileLayer
            {
                UrlTemplate = "https://a.tile.openstreetmap.org/{z}/{x}/{y}.png",
                Attribution = "&copy; <a href=\"https://www.openstreetmap.org/copyright\">OpenStreetMap</a> contributors",
            });
        }

        public async void LoadCurrentLocation()
        {
            locationProvider = new LocationProvider(_clientFactory);

            var window = await _jsRuntime.Window();
            var navigator = await window.Navigator();
            geolocationWrapper = navigator.Geolocation;

            currentPosition = await geolocationWrapper.GetCurrentPosition(new PositionOptions()
            {
                EnableHighAccuracy = true,
                MaximumAgeTimeSpan = TimeSpan.FromHours(1),
                TimeoutTimeSpan = TimeSpan.FromMinutes(1)
            });

            currentAddress = new Address((float)currentPosition.Location.Coords.Latitude, (float)currentPosition.Location.Coords.Longitude);
        }

        public async void MarkCurrentLocation()
        {
            await Task.Run(() => 
            {
                LoadCurrentLocation();
                while (currentAddress == null) { }
                Console.WriteLine(currentAddress.display_name);
                Marker mark = new Marker(currentAddress.GetLatLng()) { UseAutoPan = true, Title = "Your location" };
                AddMarker(mark);
            });
        }

        public void AddMarker(LatLng ll)
        {
            Marker mark = new Marker(ll);
            AddMarker(mark);
        }
        public void AddMarker(Marker mark)
        {
                markers.Add(mark);
                _map.AddLayer(mark);
                //_map.PanTo(mark.Position.ToPointF());
        }
        public void AddMarker(Address addr)
        {
            AddMarker(new Marker(addr.GetLatLng()) { Popup = new Popup() { Content = addr.ToString() } });
        }

        public void RemoveMarker(Marker mark)
        {
            markers.Remove(mark);
            _jsRuntime.InvokeVoidAsync("removeLayer", mark.Id);
            _map.RemoveLayer(mark);
        }

        public void RemoveMarker(Address addr)
        {
            foreach (Marker mark in markers)
            {
                if (addr.IsEqual(mark.Position))
                {
                    _map.RemoveLayer(mark);
                    markers.Remove(mark);
                }
            }
        }

        public void AddMarkers(Marker[] markers)
        {
            foreach (Marker m in markers)
            {
                AddMarker(m);
            }
        }

        public async void AddMarkerAsync(Marker mark)
        {
            await Task.Run(() => 
            {
                AddMarker(mark);
            });
        }
        public async void AddMarkerAsync(Address mark)
        {
            await Task.Run(() =>
            {
                AddMarker(mark);
            });
        }

        public async void AddPathAndBound(string path)
        {
            string pathId = StringHelper.GetRandomString(10);
            polyLines.Add(pathId);

            await Task.Run(() =>
            {
                _jsRuntime.InvokeVoidAsync("addPolyLineAndBound", new object[] { _map.Id.ToString(), path, pathId, "" });
            });
        }

        public async void AddPathAndBound(string path, string content)
        {
            string pathId = StringHelper.GetRandomString(10);
            polyLines.Add(pathId);
            await Task.Run(() =>
            {
                _jsRuntime.InvokeVoidAsync("addPolyLineAndBound", new object[] { _map.Id.ToString(), path, pathId, content });
            });
        }

        public void deleteAllMarkers()
        {
            foreach (Marker mark in markers)
            {
                _map.RemoveLayer(mark);
            }
            markers.Clear();
        }
        public void deleteAllPolylines()
        {
            foreach (string p in polyLines)
            {
                _jsRuntime.InvokeVoidAsync("removePolyline", new object[] { p, _map.Id });
            }
        }

        public Map GetMap()
        {
            return _map;
        }
    }
}
