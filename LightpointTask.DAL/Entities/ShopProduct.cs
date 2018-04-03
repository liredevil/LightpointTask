﻿
namespace LightpointTask.DAL.Entities
{
    public class ShopProduct
    {
        public int Id { get; set; }

        public int ShopId { get; set; }
        public Shop Shop { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
