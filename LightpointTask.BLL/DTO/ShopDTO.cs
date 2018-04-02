using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightpointTask.BLL.DTO
{
    public class ShopDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime TimeWorkFrom { get; set; }
        public DateTime TimeWorkTo { get; set; }
    }
}
