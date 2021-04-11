using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;

namespace Courier_service.Services.LocationService
{
    public class LocationProvider
    {
        private readonly IHttpClientFactory _clientFactory;
        public LocationProvider(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public Address getLocationData(float lon, float lat)
        {
            return GetAddress(lon, lat).Result;
        }

        public async Task<Address> GetAddress(float lon, float lat)
        {
            Address address = new Address(lat, lon);

            var request = new HttpRequestMessage(HttpMethod.Get,
                $"https://nominatim.openstreetmap.org/reverse?format=json&lat={lat.ToString().Replace(',', '.')}&lon={lon.ToString().Replace(',', '.')}&zoom=10&addressdetails=1&accept-language=ru");
            request.Headers.Add("Accept", "application/vnd.github.v3+json");
            request.Headers.Add("User-Agent", "HttpClientFactory-Course");
            var client = _clientFactory.CreateClient();
            var response = await client.SendAsync(request);
            
            if (response.IsSuccessStatusCode)
            {
                var customerJsonString = await response.Content.ReadAsStringAsync();
                try
                {
                    var addrInfo = JObject.Parse(customerJsonString);
                    foreach (var property in address.GetType().GetProperties())
                    {
                        if (addrInfo.ContainsKey(property.Name))
                        {
                            property.SetValue(address, addrInfo.GetValue(property.Name));
                        }
                    }
                }
                catch { Console.WriteLine("Не найдено"); address = null; }
            }
            else
            {
                Console.WriteLine("Error");
                address = null;
            }

            return address;
        }

        public async Task<Address> GetAddress(string addr)
        {
            Address address = new Address();
            var request = new HttpRequestMessage(HttpMethod.Get,
                $"https://nominatim.openstreetmap.org/search?limit=1&format=json&q=" + addr);
            request.Headers.Add("Accept", "application/vnd.github.v3+json");
            request.Headers.Add("User-Agent", "HttpClientFactory-Course");
            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                var customerJsonString = await response.Content.ReadAsStringAsync();
                customerJsonString = customerJsonString.Remove(0, 1);
                customerJsonString = customerJsonString.Remove(customerJsonString.Length - 1, 1);
                
                try
                {
                    var addrInfo = JObject.Parse(customerJsonString);
                    foreach (var property in address.GetType().GetProperties())
                    {
                        if (addrInfo.ContainsKey(property.Name))
                        {
                            property.SetValue(address, addrInfo.GetValue(property.Name).ToString());
                        }
                    }
                }
                catch { Console.WriteLine("Не найдено"); address = null; }
            }
            else
            {
                Console.WriteLine("Error");
                address = null;
            }

            return address;
        }

        public async Task<string> GetRouteString(Address addr1, Address addr2)
        {
            string str = "";

            var request = new HttpRequestMessage(HttpMethod.Get,
                $"https://routing.openstreetmap.de/routed-car/route/v1/driving/{addr1.GetLatLng().Lat.ToString().Replace(',', '.')},{addr1.GetLatLng().Lng.ToString().Replace(',', '.')};{addr2.GetLatLng().Lat.ToString().Replace(',', '.')},{addr2.GetLatLng().Lng.ToString().Replace(',', '.')}?overview=false&geometries=polyline&steps=true");
            request.Headers.Add("Accept", "application/vnd.github.v3+json");
            request.Headers.Add("User-Agent", "HttpClientFactory-Course");
            var client = _clientFactory.CreateClient();
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
    }
}
