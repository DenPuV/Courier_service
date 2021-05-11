using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using BlazorLeaflet.Models;
using Newtonsoft.Json;

namespace Courier_service.Services.LocationService
{
    public class LocationProvider
    {
        //private readonly IHttpClientFactory _clientFactory;
        HttpClient client = null;
        public LocationProvider(IHttpClientFactory clientFactory)
        {
            //_clientFactory = clientFactory;
            client = clientFactory.CreateClient();
        }

        public LocationProvider(HttpClient client)
        {
            this.client = client;
        }

        public Address GetAddress(float lon, float lat)
        {
            try
            {
                return AddressRequest($"https://api.openrouteservice.org/geocode/reverse?api_key=5b3ce3597851110001cf62483b8f5face1784d6db2e00f98ba26a2a9" +
                    $"&point.lon={lon.ToString().Replace(',', '.')}" +
                    $"&point.lat={lat.ToString().Replace(',', '.')}" +
                    $"&size=1").Result;
            }

            catch
            {
                return null;
            }
        }
        public Address GetAddress(LatLng latlng)
        {
            return GetAddress(latlng.Lng, latlng.Lat);
        }

        public Address GetAddress(string addr)
        {
            try
            {
                return AddressRequest($"https://api.openrouteservice.org/geocode/search?api_key=5b3ce3597851110001cf62483b8f5face1784d6db2e00f98ba26a2a9&boundary.country=RU&size=1&text=Киров " + addr).Result;
            }
            catch
            {
                return null;
            }
        }
        public List<LatLng> GetRoute(string addr1, string addr2)
        {
            try
            {
                
                return RouteRequest(LocationProvider.makeLngLatString(addr1), LocationProvider.makeLngLatString(addr2)).Result;
            }
            catch 
            {
                return null;
            }
        }

        private async Task<Address> AddressRequest(string URL)
        {
            Address address = new Address();
            var request = new HttpRequestMessage(HttpMethod.Get, URL);
            request.Headers.Add("Accept", "application/vnd.github.v3+json");
            request.Headers.Add("User-Agent", "HttpClientFactory-Course");
            //var client = _clientFactory.CreateClient();

            var response = client.Send(request);

            if (response.IsSuccessStatusCode)
            {
                var customerJsonString = await response.Content.ReadAsStringAsync();
                try
                {
                    dynamic results = JsonConvert.DeserializeObject<dynamic>(customerJsonString);
                    dynamic coordinates = results.features[0].geometry.coordinates;
                    if (coordinates != null)
                    {
                        address.lon = coordinates[0];
                        address.lat = coordinates[1];
                    }
                    dynamic properties = results.features[0].properties;
                    if (properties != null)
                    {
                        address.display_name = properties.label;
                        address.country = properties.country;
                        address.region = properties.region;
                        address.county = properties.county;
                    }
                }
                catch { address = null; }
            }
            else
            {
                address = null;
            }

            return address;
        }
        private async Task<List<LatLng>> RouteRequest(LatLng start, LatLng finish)
        {
            List<LatLng> latlngs = new List<LatLng>();
            string url = $"https://api.openrouteservice.org/v2/directions/driving-car?api_key=5b3ce3597851110001cf62483b8f5face1784d6db2e00f98ba26a2a9" +
                $"&start={start.Lat.ToString().Replace(',', '.')},{start.Lng.ToString().Replace(',', '.')}" +
                $"&end={finish.Lat.ToString().Replace(',', '.')},{finish.Lng.ToString().Replace(',', '.')}";
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Add("Accept", "application/json, application/geo+json, application/gpx+xml, img/png; charset=utf-8");
            request.Headers.Add("Authorization", "5b3ce3597851110001cf62483b8f5face1784d6db2e00f98ba26a2a9");
            //var client = _clientFactory.CreateClient();
            var response = client.Send(request);

            if (response.IsSuccessStatusCode)
            {
                var customerJsonString = await response.Content.ReadAsStringAsync();
                try
                {
                    dynamic results = JsonConvert.DeserializeObject<dynamic>(customerJsonString);
                    dynamic coordinates = results.features[0].geometry.coordinates;
                    if (coordinates != null)
                    {
                        foreach (dynamic coordinate in coordinates)
                        {
                            latlngs.Add(new LatLng((float)coordinate[0], (float)coordinate[1]));
                        }
                    }
                    
                }
                catch { latlngs = null; }
            }
            else
            {
                latlngs = null;
            }

            return latlngs;
        }

        public async Task<string> GetRouteString(Address addr1, Address addr2)
        {
            string str = "";

            var request = new HttpRequestMessage(HttpMethod.Get,
                $"https://routing.openstreetmap.de/routed-car/route/v1/driving/{addr1.GetLatLng().Lat.ToString().Replace(',', '.')},{addr1.GetLatLng().Lng.ToString().Replace(',', '.')};{addr2.GetLatLng().Lat.ToString().Replace(',', '.')},{addr2.GetLatLng().Lng.ToString().Replace(',', '.')}?overview=false&geometries=polyline&steps=true");
            request.Headers.Add("Accept", "application/vnd.github.v3+json");
            request.Headers.Add("User-Agent", "HttpClientFactory-Course");
            //var client = _clientFactory.CreateClient();
            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                var customerJsonString = await response.Content.ReadAsStringAsync();
                Regex regex = new Regex(@"\]\,""location"":\[[0-9][0-9,\., \,]+\]");
                Regex regex2 = new Regex(@"\[[0-9][0-9,\., \,]+\]");
                string temp = "";
                foreach (Match match in regex.Matches(customerJsonString)) temp += match.Value;
                MatchCollection matches = regex2.Matches(temp);
                if (matches.Count > 0)
                {
                    str += $"[[{addr1.GetLatLng().Lat.ToString().Replace(',', '.')},{addr1.GetLatLng().Lng.ToString().Replace(',', '.')}],";
                    foreach (Match m in matches)
                    {
                        str += m.Value + ",";
                    }
                    str += $"[{addr2.GetLatLng().Lat.ToString().Replace(',', '.')},{addr2.GetLatLng().Lng.ToString().Replace(',', '.')}]]";
                    Console.WriteLine(str);
                }
            }
            else
            {
                Console.WriteLine("Error");
            }

            return str;
        }

        public static string makePath(LatLng latlng1, LatLng latlng2) 
        {
            return $"[[{latlng1.Lat.ToString().Replace(',', '.')},{latlng1.Lng.ToString().Replace(',', '.')}],[{latlng2.Lat.ToString().Replace(',', '.')},{latlng2.Lng.ToString().Replace(',', '.')}]]";
        }
        public static string makePath(List<LatLng> latlngs)
        {
            string str = "[";
            if (latlngs != null)
            {
                foreach (LatLng l in latlngs)
                {
                    str += $"[{l.Lng.ToString().Replace(',', '.')},{l.Lat.ToString().Replace(',', '.')}],";
                }
                str += "]";
                str = str.Replace(",]", "]");
            }
            return str;
        }
        public static string makeStringLatlng(LatLng ll)
        {
            return $"[{ll.Lat.ToString().Replace(',', '.')},{ll.Lng.ToString().Replace(',', '.')}]";
        }
        public static LatLng makeLngLatString(string ll)
        {
            try
            {
                dynamic results = JsonConvert.DeserializeObject<dynamic>(ll);
                LatLng latlng = new LatLng((float)results[1], (float)results[0]);
                return latlng;
            }
            catch 
            {
                return null;
            }
        }
    }
}
