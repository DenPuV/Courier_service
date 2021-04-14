using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Courier_service.Models
{
    [Table("Package")]
    public class Package
    {
        public int Id { get; set; }
        public string Weight { get; set; }
        public string Description { get; set; }
    }
}
