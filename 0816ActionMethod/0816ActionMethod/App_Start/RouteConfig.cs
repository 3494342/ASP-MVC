using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _0816ActionMethod
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();//使能属性routing

            //    routes.MapRoute(
            //      name: "Contact",
            //      url: "Contact-us",
            //      defaults: new { controller = "Method", action = "Contact" }
            //  );
            //routes.MapRoute("greet", "{action}/{controller}");//修改pattern
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            //    routes.MapRoute(
            //    name: "Courses",
            //    url: "Courses/{title}",
            //    constraints: new { title = "c|name" },
            //    defaults: new { controller = "Method", action = "Courses" }
            //);
            //    routes.MapRoute(
            //     name: "display",
            //     url: "display/{cid}",
            //     constraints: new { cid = @"\d{1,3}" },
            //     defaults: new { controller = "Method", action = "display" }
            // );


        }
    }
}
