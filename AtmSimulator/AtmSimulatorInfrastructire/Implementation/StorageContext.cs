using AtmSimulatorInfrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmSimulatorInfrastructure.Implementation
{
    public  class StorageContext : AtmSimulatorContext, IStorageContext
    {
        private string _connectionString;
        public StorageContext(DbContextOptions<AtmSimulatorContext> options, string connectionString) : base(options)
        {
            _connectionString = connectionString;       
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql(this._connectionString);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
