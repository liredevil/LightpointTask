using System.Collections.Generic;
using System.Linq;
using LightpointTask.DAL.EF;
using LightpointTask.DAL.Entities;
using LightpointTask.DAL.Interfaces;

namespace LightpointTask.DAL.Repositories
{
    public class ShopProductRepositories : IShopProduct<ShopProduct>
    {
        private DatabaseContext db;

        public ShopProductRepositories(DatabaseContext context)
        {
            db = context;
        }

        public void AddDate(int productId, int shopId)
        {
            ShopProduct shopProduct = new ShopProduct
            {
                ProductId = productId,
                ShopId = shopId
            };

            db.ShopProducts.Add(shopProduct);
        }

        public IEnumerable<Product> GetProductById(int id)
        {
            return (from p in db.ShopProducts
                    where p.ShopId == id
                    select new
                    {
                        Id = p.Product.Id,
                        Name = p.Product.Name,
                        Description = p.Product.Description
                    }).ToList().Select(x => new Product
                    {
                        Id = x.Id,
                        Name = x.Name,
                        Description = x.Description
                    }).ToList();
        }
    }
}
