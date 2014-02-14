using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Sniffsters
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Breeders",
                url: "Dog-Breeders",
                defaults: new { controller = "Breeders", action = "BreedersAction", id = UrlParameter.Optional }
            );
            

            routes.MapRoute(
                name: "Dogs",
                url: "Dogs-Puppies-Litters",
                defaults: new {controller = "Dogs", action = "DogsAction", id = UrlParameter.Optional}
                );

            routes.MapRoute(
                name: "Explore",
                url: "Explore",
                defaults: new {controller = "Explore", action = "ExploreAction", id = UrlParameter.Optional}
                );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "HomeAction", id = UrlParameter.Optional }
            );

        }
    }
}
