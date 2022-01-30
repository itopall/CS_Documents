using ETrade.Service.Service;
using ETrade.UI.BackEnd.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Unity;
using Unity.AspNet.Mvc;

namespace ETrade.UI.BackEnd
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            IoCConfigure();
        }

        private void IoCConfigure()
        {
            UnityContainer container = new UnityContainer();

            container.RegisterType<IMemberService, MemberService>();
            container.RegisterType<IEmployeeService, EmployeeService>();
            container.RegisterType<IEmployeeTypeService, EmployeeTypeService>();
            container.RegisterType<ICategoryService, CategoryService>();
            container.RegisterType<IProductService, ProductService>();
            container.RegisterType<ISupplierService, SupplierService>();
            container.RegisterType<IPurchaseOrderService, PurchaseOrderService>();
            container.RegisterType<IProductImageService, ProductImageService>();
            container.RegisterType<IBasketService, BasketService>();
            container.RegisterType<IBasketDetailService, BasketDetailService>();

            IoCManager.Container = container;
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
