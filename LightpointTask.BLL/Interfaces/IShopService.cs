﻿using System.Collections.Generic;
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
