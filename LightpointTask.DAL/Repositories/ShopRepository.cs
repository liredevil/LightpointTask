using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using LightpointTask.DAL.Entities;
using LightpointTask.DAL.EF;
using LightpointTask.DAL.Interfaces;

namespace LightpointTask.DAL.Repositories
{
    public class ShopRepository : IRepository<Shop>
    {
        private DatabaseContext db;

        public ShopRepository(DatabaseContext context)
        {
            db = context;
        }

        public IEnumerable<Shop> GetAll()
        {
            return db.Shops;
        }

        public Shop Get(int id)
        {
            return db.Shops.Find(id);
        }

        public void Create(Shop shop)
        {
            db.Shops.Add(shop);
        }

        public void Update(Shop shop)
        {
            db.Entry(shop).State = EntityState.Modified;
        }

        public IEnumerable<Shop> Find(Func<Shop, Boolean> predicate)
        {
            return db.Shops.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Shop shop = db.Shops.Find(id);
            if (shop != null)
                db.Shops.Remove(shop);
        }
    }
}
