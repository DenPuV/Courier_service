using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Courier_service.Models
{
    [Table("Contact")]
    public class Contact
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string SName { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
    }
}
