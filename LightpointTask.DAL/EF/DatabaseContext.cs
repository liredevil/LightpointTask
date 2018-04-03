using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using LightpointTask.DAL.Entities;

namespace LightpointTask.DAL.EF
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShopProduct> ShopProducts { get; set; }
        //static DatabaseContext()
        //{
        //    Database.SetInitializer<DatabaseContext>(new StoreDbInitializer());
        //}

        public DatabaseContext(string connectionString)
            : base(connectionString)
        {

        }
    }

    //public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<DatabaseContext>
    //{
    //    protected override void Seed(DatabaseContext db)
    //    {
    //        db.Shops.Add(new Shop { Name = "Colins" });
    //        db.SaveChanges();
    //    }
    //}
}
