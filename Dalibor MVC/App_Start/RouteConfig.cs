using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Dalibor_MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("vzdelanie", "vzdelanie", new { controller = "Home", action = "Vzdelanie" });
            routes.MapRoute("galeria", "galeria", new { controller = "Home", action = "Galeria" });
            routes.MapRoute("omne", "omne", new { controller = "Home", action = "Omne" });
            routes.MapRoute("zamestnanie", "zamestnanie", new { controller = "Home", action = "Zamestnanie" });
            routes.MapRoute("kontakt", "kontakt", new { controller = "Home", action = "Kontakt" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Intro", id = UrlParameter.Optional }
            );
        }
    }
}
