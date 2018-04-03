using System.Collections.Generic;

namespace LightpointTask.DAL.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Create(T item);
        void Delete(int id);
        IEnumerable<T> GetAll();
    }
}
