using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _01_Routing
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            //Mvc 5'den önce routing yapılandırmaları sadece RouteConfig üzerinden yani burada yapılabilirdi. 
            //wwww.tatil.com/otel/detay/hilton-umraniye
            //wwww.tatil.com/otel/detay/hilton-mecidiyeköy
            //routes.MapRoute(
            //    name: "Default",
            //    url: "{otel}/{detay}/{name}",
            //    defaults: new { controller = "Hotel", action = "Detail", name = UrlParameter.Optional }
            //);
        }
    }
}
