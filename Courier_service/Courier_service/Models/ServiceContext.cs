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
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Courier> Couriers { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Route> Routes { get; set; }
    }

    public class DatabaseService
    {
        public readonly ServiceContext _dbcontext;

        public DatabaseService(ServiceContext _db)
        {
            _dbcontext = _db;
        }

        public DatabaseService()
        {
            _dbcontext = new ServiceContext();
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
        public Package AddPackage(Package package)
        {
            Package p = _dbcontext.Packages.Add(package).Entity;
            SaveData();
            return p;
        }
        public Contact AddContact(Contact contact)
        {
            Contact c = _dbcontext.Contacts.Add(contact).Entity;
            SaveData();
            return c;
        }
        public Route AddRoute(Route route)
        {
            Route r = _dbcontext.Add(route).Entity;
            SaveData();
            return r;
        }
        public void PlaceOrder(Package package, Contact contact, Route route, Client client, decimal price )
        {
            package = AddPackage(package);
            contact = AddContact(contact);
            route = AddRoute(route);
            Order order = new Order() {
                Date = DateTime.Now,
                Price = price,
                ClientId = client.Id,
                ContactId = contact.Id,
                PackageId = package.Id,
                RouteId = route.Id,
                Status = "New order",
                Type = ""
            };
            _dbcontext.Orders.Add(order);
            try
            {
                SaveData();
            }
            catch
            {
                _dbcontext.Orders.Remove(order);
                _dbcontext.Packages.Remove(package);
                _dbcontext.Contacts.Remove(contact);
                _dbcontext.Routes.Remove(route);
                throw new Exception("Cannot commit transaction");
            }
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

        public Client GetClient(string userId)
        {
            var cl = from c in _dbcontext.Clients
                     where c.AspName == userId
                     select c;

            return (cl.Count() > 0) ? cl.First() : null;
        }
    }
}
