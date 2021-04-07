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
        public async Task<List<Client>> ClientDataAsync()
        {
            return await Task.Run(() => ClientData());
        }

        public void AddClient(Client client)
        {
            _dbcontext.Clients.Add(client);
            SaveData();
        }

        public async void SaveData()
        {
            try { await _dbcontext.SaveChangesAsync(); }
            catch { }
        }

        public void UpdateClient(Client client) 
        {
            try
            {
                Client cl = _dbcontext.Clients.Find(client.Id);
                if (cl != null)
                {
                    _dbcontext.Entry<Client>(cl).CurrentValues.SetValues(client);
                    _dbcontext.SaveChanges();
                }
            }
            catch { }
        }
    }
}
