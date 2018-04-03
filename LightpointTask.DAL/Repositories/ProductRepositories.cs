using System.Collections.Generic;
using LightpointTask.DAL.Entities;
using LightpointTask.DAL.EF;
using LightpointTask.DAL.Interfaces;

namespace LightpointTask.DAL.Repositories
{
    public class ProductRepositories : IRepository<Product>
    {
        private DatabaseContext db;

        public ProductRepositories(DatabaseContext context)
        {
            db = context;
        }

        public void Create(Product product)
        {
            db.Products.Add(product);
        }

        public void Delete(int id)
        {
            Product product = db.Products.Find(id);
            if (product != null)
            {
                db.Products.Remove(product);
            }
        }

        public IEnumerable<Product> GetAll()
        {
            return db.Products;
        }
    }
}
