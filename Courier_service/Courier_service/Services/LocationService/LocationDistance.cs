using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorLeaflet.Models;
using Newtonsoft.Json;

namespace Courier_service.Services.LocationService
{
    public class LocationDistance
    {
        const double PIx = 3.141592653589793;
        const double RADIUS = 6378.16;

        /// <summary>
        /// Convert degrees to Radians
        /// </summary>
        /// <param name="x">Degrees</param>
        /// <returns>The equivalent in radians</returns>
        public static double Radians(double x)
        {
            return x * PIx / 180;
        }

        /// <summary>
        /// Calculate the distance between two places.
        /// </summary>
        /// <param name="lon1"></param>
        /// <param name="lat1"></param>
        /// <param name="lon2"></param>
        /// <param name="lat2"></param>
        /// <returns></returns>
        public static double DistanceBetweenPlaces(
            double lon1,
            double lat1,
            double lon2,
            double lat2)
        {
            double dlon = Radians(lon2 - lon1);
            double dlat = Radians(lat2 - lat1);

            double a = (Math.Sin(dlat / 2) * Math.Sin(dlat / 2)) + Math.Cos(Radians(lat1)) * Math.Cos(Radians(lat2)) * (Math.Sin(dlon / 2) * Math.Sin(dlon / 2));
            double angle = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return angle * RADIUS * 1000;
        }

        public static double DistanceBetweenPlaces(LatLng loc1, LatLng loc2)
        {
            return DistanceBetweenPlaces(loc1.Lng, loc1.Lat, loc2.Lng, loc2.Lat);
        }

        public static double DistanceBetweenPlaces(string loc1, string loc2)
        {
            return DistanceBetweenPlaces(ParseLatLng(loc1), ParseLatLng(loc2));
        }

        public static LatLng ParseLatLng(string str)
        {
            try
            {
                dynamic results = JsonConvert.DeserializeObject<dynamic>(str);
                return new LatLng((float)results[0], (float)results[1]);
            }
            catch
            {
                return null;
            }
        }
    }
}
