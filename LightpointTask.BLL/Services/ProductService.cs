using LightpointTask.BLL.DTO;
using LightpointTask.DAL.Entities;
using LightpointTask.DAL.Interfaces;
using LightpointTask.BLL.Interfaces;
using System.Collections.Generic;
using AutoMapper;

namespace LightpointTask.BLL.Services
{
    public class ProductService : IProductService
    {
        IUnitOfWork Database { get; set; }

        public ProductService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public void MakeProduct(ProductDTO productDto)
        {
            Product product = new Product
            {
                Name = productDto.Name,
                Description = productDto.Description
            };

            Database.Products.Create(product);
            Database.Save();
        }

        public void DeleteProduct(int id)
        {
            Database.Products.Delete(id);
            Database.Save();
        }

        public IEnumerable<ProductDTO> GetProducts()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Product>, List<ProductDTO>>(Database.Products.GetAll());
        }


        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
