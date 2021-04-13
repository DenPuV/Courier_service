using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata;
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
        public ServiceContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=Courier_service;User Id=postgres;Password=230798");
            }
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
        }

        public void SaveData()
        {
            try
            {
            _dbcontext.SaveChanges(); 
            }
            catch(Exception ex) { throw new Exception(ex.Message); }
        }

        public void UpdateClient(Client client) 
        {
                Client cl = _dbcontext.Clients.Find(client.Id);
                if (cl != null)
                {
                    _dbcontext.Entry<Client>(cl).CurrentValues.SetValues(client);
                }
        }
    }
}
