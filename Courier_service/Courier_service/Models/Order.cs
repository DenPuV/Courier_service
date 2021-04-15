using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Courier_service.Models
{
    [Table("Orders")]
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        public int ContactId { get; set; }
        [NotMapped]
        public Contact Contact { get; set; }
        public int ClientId { get; set; }
        [NotMapped]
        public Client Client { get; set; }
        public int RouteId { get; set; }
        [NotMapped]
        public Route Route { get; set; }
        public int PackageId { get; set; }
        [NotMapped]
        public Package Package { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }

        [NotMapped]
        public Delivery  Delivery{ get; set; }
    }
}
