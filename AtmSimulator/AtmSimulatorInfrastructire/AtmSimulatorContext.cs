using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmSimulatorInfrastructure
{
    public class AtmSimulatorContext : IdentityDbContext
    {
        private readonly DbContextOptions _options;
        public AtmSimulatorContext(DbContextOptions options) : base(options)
        {
            _options = options;
        }


    }
}
