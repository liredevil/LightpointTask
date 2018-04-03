using LightpointTask.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightpointTask.DAL.Interfaces
{
    public interface IShopProduct<T> where T : class
    {
        void AddDate(int productId, int shopId);
        IEnumerable<Product> GetProductById(int id);
    }
}
