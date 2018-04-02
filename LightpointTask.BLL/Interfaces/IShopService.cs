using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LightpointTask.BLL.DTO;

namespace LightpointTask.BLL.Interfaces
{
    public interface IShopService
    {
        void MakeShop(ShopDTO shopDto);
        void DeleteShop(int id);
        IEnumerable<ShopDTO> GetShops();
        void Dispose();
    }
}
