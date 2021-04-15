using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Courier_service.Services.LocationService;

namespace Courier_service.Models
{
    [Table("Route")]
    public class Route
    {
        public int Id { get; set; }
        public string StartCoordinates { get; set; }
        public string StartName { get; set; }
        public string FinishCoordinates { get; set; }
        public string FinishName { get; set; }

        [NotMapped]
        public Address StartAddress { get; set; }
        [NotMapped]
        public Address FinishAddress { get; set; }
    }
}
