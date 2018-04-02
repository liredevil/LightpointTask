using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using LightpointTask.DAL.Entities;

namespace LightpointTask.DAL.EF
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<ShopProduct> ShopProducts { get; set; }

        static DatabaseContext()
        {
            Database.SetInitializer<DatabaseContext>(new CreateDatabaseIfNotExists<DatabaseContext>());
        }

        public DatabaseContext(string connectionString)
            : base(connectionString)
        {

        }
    }
}
