using Northwnd.Service.Services;
using Northwnd.Service.Services.Interface;
using Northwnd.UI.Web.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Unity;
using Unity.AspNet.Mvc;

namespace Northwnd.UI.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            IoCConfigure();
        }

        private void IoCConfigure()
        {
            UnityContainer container = new UnityContainer();

            container.RegisterType<IProductService, ProductServiceTest>();
            container.RegisterType<IPersonelService, PersonelService>();

            IoCManager.Container = container;
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
