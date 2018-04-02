using Ninject;
using Ninject.Modules;
using Ninject.Web.Mvc;
using LightpointTask.BLL.Infrastructure;
using LightpointTask.Util;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace LightpointTask
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // внедрение зависимостей
            NinjectModule shopModule = new DependencesModule();
            NinjectModule serviceModule = new ServiceModule("DefaultConnection");

            var kernel = new StandardKernel(shopModule, serviceModule);

            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }
    }
}
