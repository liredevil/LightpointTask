using LightpointTask.DAL.Entities;
using System.Collections.Generic;

namespace LightpointTask.DAL.Interfaces
{
    public interface IShopProduct<T> where T : class
    {
        void AddDate(int productId, int shopId);
        IEnumerable<Product> GetProductById(int id);
    }
}
