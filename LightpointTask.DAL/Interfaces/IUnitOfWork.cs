using LightpointTask.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightpointTask.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Shop> Shops { get; }
        IRepository<Product> Products { get; }
        void Save();
    }
}
