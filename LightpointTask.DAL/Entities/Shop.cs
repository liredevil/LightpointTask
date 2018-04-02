using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightpointTask.DAL.Entities
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime TimeWorkFrom { get; set; }
        public DateTime TimeWorkTo { get; set; }

        public ICollection<ShopProduct> ShopsProduct { get; set; }
    }
}
