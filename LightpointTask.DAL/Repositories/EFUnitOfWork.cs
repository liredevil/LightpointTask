using System;
using LightpointTask.DAL.EF;
using LightpointTask.DAL.Interfaces;
using LightpointTask.DAL.Entities;

namespace LightpointTask.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private DatabaseContext db;
        private ShopRepository shopRepository;
        private ProductRepositories productRepositories;
        private ShopProductRepositories shopProductRepositories;

        public EFUnitOfWork(string connectionString)
        {
            db = new DatabaseContext(connectionString);
        }

        public IRepository<Shop> Shops
        {
            get
            {
                if (shopRepository == null)
                    shopRepository = new ShopRepository(db);
                return shopRepository;
            }
        }

        public IRepository<Product> Products
        {
            get
            {
                if (productRepositories == null)
                    productRepositories = new ProductRepositories(db);
                return productRepositories;
            }
        }

        public IShopProduct<ShopProduct> ShopProducts
        {
            get
            {
                if (shopProductRepositories == null)
                    shopProductRepositories = new ShopProductRepositories(db);
                return shopProductRepositories;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
