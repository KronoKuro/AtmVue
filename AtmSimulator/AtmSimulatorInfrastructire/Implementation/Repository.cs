using AtmSimulatorInfrastructure.Entities;
using AtmSimulatorInfrastructure.Interfaces;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmSimulatorInfrastructure.Implementation
{
    public class Repository<TDbContext> : IRepository where TDbContext : AtmSimulatorContext
    {
        //public readonly IList<Item> items;
        //private DbSet<Item> itemSet;
        private TDbContext _storageContext;

        public Repository(TDbContext storageContext)
        {
            _storageContext = storageContext;
            //this.items = new List<Item>();
            //this.items.Add(new Item() { Id = 1, Name = "Mock item 1" });
            //this.items.Add(new Item() { Id = 2, Name = "Mock item 2" });
            //this.items.Add(new Item() { Id = 3, Name = "Mock item 3" });
        }
      
        
        public IEnumerable<T> Get<T>() where T : class
        {
            return _storageContext.Set<T>().ToList();
        }

        public void SetStorageContext(IStorageContext sotrageContext)
        {
            
        }
    }
}
