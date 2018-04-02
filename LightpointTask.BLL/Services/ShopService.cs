using System;
using LightpointTask.BLL.DTO;
using LightpointTask.DAL.Entities;
using LightpointTask.DAL.Interfaces;
using LightpointTask.BLL.Infrastructure;
using LightpointTask.BLL.Interfaces;
using System.Collections.Generic;
using AutoMapper;

namespace LightpointTask.BLL.Services
{
    public class ShopService : IShopService
    {
        IUnitOfWork Database { get; set; }

        public ShopService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public void MakeShop(ShopDTO shopDto)
        {
            Shop shop = new Shop
            {
                Name = shopDto.Name,
                TimeWorkFrom = shopDto.TimeWorkFrom,
                TimeWorkTo = shopDto.TimeWorkTo
            };

            Database.Shops.Create(shop);
            Database.Save();
        }

        public void DeleteShop(int id)
        {
            Database.Shops.Delete(id);
            Database.Save();
        }

        public IEnumerable<ShopDTO> GetShops()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Shop, ShopDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Shop>, List<ShopDTO>>(Database.Shops.GetAll());
        }


        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
