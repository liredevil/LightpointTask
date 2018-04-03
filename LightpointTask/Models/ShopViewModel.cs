using System;
using System.ComponentModel.DataAnnotations;


namespace LightpointTask.Models
{
    public class ShopViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime TimeWorkFrom { get; set; }

        [Required]
        public DateTime TimeWorkTo { get; set; }
    }
}