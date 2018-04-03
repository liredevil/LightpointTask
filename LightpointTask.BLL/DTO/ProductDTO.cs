using LightpointTask.DAL.Entities;
using System.Collections.Generic;


namespace LightpointTask.BLL.DTO
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<ShopProduct> ShopProducts { get; set; }
    }
}
