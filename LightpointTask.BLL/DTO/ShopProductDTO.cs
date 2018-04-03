using LightpointTask.DAL.Entities;

namespace LightpointTask.BLL.DTO
{
    public class ShopProductDTO
    {
        public int Id { get; set; }
        public int ShopId { get; set; }
        public int ProductId { get; set; }
        public Shop Shop { get; set; }
        public Product Product { get; set; }
    }
}
