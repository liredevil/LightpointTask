using LightpointTask.DAL.Entities;
using System;

namespace LightpointTask.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Shop> Shops { get; }
        IRepository<Product> Products { get; }
        IShopProduct<ShopProduct> ShopProducts { get; }
        void Save();
    }
}
