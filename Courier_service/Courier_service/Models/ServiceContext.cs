using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Courier_service.Models
{
    public class ServiceContext : DbContext
    {
        public ServiceContext(DbContextOptions<ServiceContext> options):base(options)
        {
            
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<AspNetUser> AspNetUsers { get; set; }
    }

    public class DatabaseService
    {
        protected readonly ServiceContext _dbcontext;

        public DatabaseService(ServiceContext _db)
        {
            _dbcontext = _db;
        }

        public List<Client> ClientData()
        {
            try { return _dbcontext.Clients.ToList(); }
            catch { return null; }
        }

        public List<AspNetUser> AspNetUsersData()
        {
            return _dbcontext.AspNetUsers.ToList();
        }

        public async Task<List<Client>> ClientDataAsync()
        {
            return await Task.Run(() => ClientData());
        }
    }
}
