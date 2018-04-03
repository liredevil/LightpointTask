using LightpointTask.DAL.Entities;
using System;
using System.Collections.Generic;

namespace LightpointTask.BLL.DTO
{
    public class ShopDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime TimeWorkFrom { get; set; }
        public DateTime TimeWorkTo { get; set; }

        public ICollection<ShopProduct> ShopsProduct { get; set; }
    }
}
