using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Courier_service.Models
{
    public class ServiceContext : DbContext
    {
        public DbSet<Client> Clinets { get; set; }
        public ServiceContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("DefaultConnection");
        }
    }
}
