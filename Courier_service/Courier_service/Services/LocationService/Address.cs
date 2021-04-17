using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;
using System.Drawing;
using BlazorLeaflet.Models;
using System.Globalization;

namespace Courier_service.Services.LocationService
{
    public class Address
    {
        public Address() { }
        public Address(float lat, float lng)
        {
            Lat = lat;
            Lng = lng;
        }

        public Address(LatLng ll)
        {
            Lat = ll.Lat;
            Lng = ll.Lng;
        }

        float? Lat { get; set; }
        float? Lng { get; set; }
        public string lat { get { return (Lat.HasValue) ? Lat.Value.ToString() : ""; } set { Lat = float.Parse(value, CultureInfo.InvariantCulture.NumberFormat); } }
        public string lon { get { return (Lng.HasValue) ? Lng.Value.ToString() : ""; } set { Lng = float.Parse(value, CultureInfo.InvariantCulture.NumberFormat); } }
        public string country { get; set; }
        public string region { get; set; }
        public string county { get; set; }
        public string display_name { get; set; } = "";

        public override string ToString()
        {
            string str = "";
            if (display_name != "") str = display_name;
            else
            {
                foreach (var item in this.GetType().GetProperties())
                {
                    string name = item.Name;
                    var value = item.GetValue(this);
                    if (value != null) str += $"{name}: {value}; ";
                }
            }
            return str;
        }

        public LatLng GetLatLng()
        {
            if (Lat.HasValue)
            {
                if (Lng.HasValue)
                {
                    return new LatLng(Lat.Value, Lng.Value);
                }
            }
            return null;
        }
        public PointF GetPointF()
        {
            LatLng ll = GetLatLng();
            if (ll != null) return ll.ToPointF();
            else return new PointF();
        }

        public bool IsEqual(LatLng ltlg)
        {
            if (Lat.HasValue && Lng.HasValue)
            {
                if (Lat.Value == ltlg.Lat && Lng.Value == ltlg.Lng) return true;
                else return false;
            }
            else return false;
        }

        
    }
}
