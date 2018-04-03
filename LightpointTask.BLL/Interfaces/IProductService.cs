using LightpointTask.BLL.DTO;
using System.Collections.Generic;

namespace LightpointTask.BLL.Interfaces
{
    public interface IProductService
    {
        void MakeProduct(ProductDTO shopDto);
        void DeleteProduct(int id);
        IEnumerable<ProductDTO> GetProducts();
        void Dispose();
    }
}
