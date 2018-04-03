using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LightpointTask.DAL.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public ICollection<ShopProduct> ShopProducts { get; set; }
    }
}
