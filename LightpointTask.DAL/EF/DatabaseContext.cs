using System;
using System.Data.Entity;
using LightpointTask.DAL.Entities;

namespace LightpointTask.DAL.EF
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShopProduct> ShopProducts { get; set; }

        static DatabaseContext()
        {
            Database.SetInitializer<DatabaseContext>(new StoreDbInitializer());
        }

        public DatabaseContext(string connectionString)
            : base(connectionString)
        {

        }
    }

    public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext db)
        {
            DateTime date1 = new DateTime(2015,7,20,8,00,30);
            DateTime date2 = new DateTime(2015, 7, 20, 16, 00, 30);

            db.Shops.Add(new Shop { Name = "OZ.BY", TimeWorkFrom = date1, TimeWorkTo = date2 });
            db.Shops.Add(new Shop { Name = "Steam", TimeWorkFrom = date1, TimeWorkTo = date2 });
            db.Shops.Add(new Shop { Name = "GAMESHOP", TimeWorkFrom = date1, TimeWorkTo = date2 });
            db.Products.Add(new Product { Name = "World of Warcraft. Рождение Орды", Description = "Кристи Голден, 2017" });
            db.Products.Add(new Product { Name = "Аэропорт", Description = "Аэропорт — бестселлер Артура Хейли." });
            db.Products.Add(new Product { Name = "451 градус по Фаренгейту", Description = "Рэй брэдбери" });
            db.Products.Add(new Product { Name = "A Way Out", Description = "2014" });
            db.Products.Add(new Product { Name = "farcry 5", Description = "2018" });
            db.Products.Add(new Product { Name = "Portal", Description = "2008" });
            db.SaveChanges();
            db.ShopProducts.Add(new ShopProduct { ProductId = 1, ShopId = 1 });
            db.ShopProducts.Add(new ShopProduct { ProductId = 2, ShopId = 1 });
            db.ShopProducts.Add(new ShopProduct { ProductId = 3, ShopId = 1 });
            db.ShopProducts.Add(new ShopProduct { ProductId = 4, ShopId = 2 });
            db.ShopProducts.Add(new ShopProduct { ProductId = 5, ShopId = 2 });
            db.ShopProducts.Add(new ShopProduct { ProductId = 6, ShopId = 2 });
            db.ShopProducts.Add(new ShopProduct { ProductId = 5, ShopId = 3 });
            db.ShopProducts.Add(new ShopProduct { ProductId = 4, ShopId = 3 });
            db.SaveChanges();
        }
    }
}
