using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightpointTask.DAL.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Create(T item);
        void Delete(int id);
        IEnumerable<T> GetAll();
    }
}
