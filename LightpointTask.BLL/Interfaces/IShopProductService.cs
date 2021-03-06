﻿using System.Collections.Generic;
using LightpointTask.BLL.DTO;

namespace LightpointTask.BLL.Interfaces
{
    public interface IShopProductService
    {
       
        void AddShopProduct(int productId, int shopId);
        IEnumerable<ProductDTO> GetProductById(int id);
        void Dispose();
    }
}
