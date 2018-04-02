using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LightpointTask.Models
{
    public class ShopViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime TimeWorkFrom { get; set; }
        public DateTime TimeWorkTo { get; set; }
    }
}