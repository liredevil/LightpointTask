using LightpointTask.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
