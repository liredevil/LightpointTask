using System;
using LightpointTask.DAL.EF;
using LightpointTask.DAL.Interfaces;
using LightpointTask.DAL.Entities;

namespace LightpointTask.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private DatabaseContext db;
        private ProductRepository productRepository;
        private ShopRepository shopRepository;

        public EFUnitOfWork(string connectionString)
        {
            db = new DatabaseContext(connectionString);
        }

        public IRepository<Product> Products
        {
            get
            {
                if (productRepository == null)
                    productRepository = new ProductRepository(db);
                return productRepository;
            }
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
