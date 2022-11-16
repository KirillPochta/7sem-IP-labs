using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "V2MResearchMO2",
               url: "V2/{controller}/{action}/{id}",
               defaults: new { controller = "MResearch", action = "MO2" , id = UrlParameter.Optional }
               );
            
            routes.MapRoute(
                name: "V3ResearchMO3",
                url: "V3/{controller}/X/{action}/{id}",
                defaults: new { controller = "MResearch",  action = "MO3", id = UrlParameter.Optional }
                );
            
            routes.MapRoute(
                name: "V3ResearchMO31",
                url: "V3/{controller}/{action}/{id}",
                defaults: new { controller = "MResearch",  action = "MO3", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "Defualt",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "MResearch", action = "MO1", id = UrlParameter.Optional }
                );
        }
    }
}
