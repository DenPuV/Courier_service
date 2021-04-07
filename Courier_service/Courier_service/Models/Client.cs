using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Courier_service.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string FName { get; set; }
        public string SName { get; set; }
        public string Patronymic { get; set; }
        public bool Deleted { get; set; } = false;
        public string AspName { get; set; }
    }
}
