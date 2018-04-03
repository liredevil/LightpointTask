using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LightpointTask.DAL.Entities
{
    public class Shop
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime TimeWorkFrom { get; set; }

        [Required]
        public DateTime TimeWorkTo { get; set; }

        public ICollection<ShopProduct> ShopsProduct { get; set; }
    }
}
