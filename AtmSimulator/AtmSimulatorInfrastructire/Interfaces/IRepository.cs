using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmSimulatorInfrastructure.Interfaces
{
    public interface IRepository
    {
        //void SetStorageContext(IStorageContext sotrageContext);
        IEnumerable<T> Get<T>() where T : class;

    }
}
