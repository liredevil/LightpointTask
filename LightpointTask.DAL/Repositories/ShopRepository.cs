using System.Collections.Generic;
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

        public void Create(Shop shop)
        {
            db.Shops.Add(shop);
        }

        public void Delete(int id)
        {
            Shop shop = db.Shops.Find(id);
            if(shop != null)
            {
                db.Shops.Remove(shop);
            }
        }

        public IEnumerable<Shop> GetAll()
        {
            return db.Shops;
        }
    }
}
