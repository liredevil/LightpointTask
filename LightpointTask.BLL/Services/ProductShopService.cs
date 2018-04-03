using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using LightpointTask.BLL.DTO;
using LightpointTask.BLL.Interfaces;
using LightpointTask.DAL.Entities;
using LightpointTask.DAL.Interfaces;

namespace LightpointTask.BLL.Services
{
    public class ProductShopService : IShopProductService
    {
        IUnitOfWork Database { get; set; }

        public ProductShopService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public void AddShopProduct(int productId, int shopId)
        {
            Database.ShopProducts.AddDate(productId, shopId);
            Database.Save();
        }

        public void Dispose()
        {
            Database.Dispose();
        }

        public IEnumerable<ProductDTO> GetProductById(int id)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductDTO>()).CreateMapper();

            return mapper.Map<IEnumerable<Product>, List<ProductDTO>>(Database.ShopProducts.GetProductById(id));
            //return mapper.Map<IEnumerable<ShopProduct>, List<ProductDTO>>(Database.ShopProducts.GetProductById(id));
        }
    }
}
