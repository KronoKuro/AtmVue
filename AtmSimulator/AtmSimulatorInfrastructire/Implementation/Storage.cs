//using AtmSimulatorInfrastructure.Interfaces;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;

//namespace AtmSimulatorInfrastructure.Implementation
//{
//    public class Storage : IStorage
//    {
//        public StorageContext Context { get; private set; }
//        public Storage(DbContextOptions<AtmSimulatorContext> options, string connectionString) 
//        {
//            this.Context = new StorageContext(options, connectionString);
//        }


//        public T GetRepoitory<T>() where T : IRepository
//        {
//            foreach (Type t in this.GetType().GetTypeInfo().Assembly.GetTypes())
//            {
//                if (typeof(T).GetTypeInfo().IsAssignableFrom(t) && t.GetTypeInfo().IsClass)
//                {
//                    T repos = (T)Activator.CreateInstance(t);
//                    repos.SetStorageContext(this.Context);
//                    return repos;
//                }
//            }
//            return default(T);
//        }

//        public async Task Save()
//        {
//            await this.Context.SaveChangesAsync();
//        }
//    }
//}
