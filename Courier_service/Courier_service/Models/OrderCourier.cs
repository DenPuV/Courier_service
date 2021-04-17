using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Courier_service.Models;

namespace Courier_service.Models
{
    [Table("OrderCourier")]
    public class OrderCourier
    {
        [Key]
        public int OrderId { get; set; }
        [NotMapped]
        public Order Order { get; set; }
        public int CourierId { get; set; }
        [NotMapped]
        public Courier Courier { get; set; }
    }
}
