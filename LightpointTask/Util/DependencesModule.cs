using Ninject.Modules;
using LightpointTask.BLL.Services;
using LightpointTask.BLL.Interfaces;

namespace LightpointTask.Util
{
    public class DependencesModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IShopService>().To<ShopService>();
            Bind<IProductService>().To<ProductService>();
        }
    }
}