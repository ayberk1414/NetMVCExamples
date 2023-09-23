using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Example01
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {

            // localhost : 123234/berkay

            //Daha özel olan daha önce yazılmalı .... net de de, net core da da.


            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            // Anasayfa


            //    routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{name}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional, name = UrlParameter.Optional }
            //);


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{name}",
                defaults: new { controller = "Home", action = "Index", name = UrlParameter.Optional }
            );

            //berkay => 






            //Save();
        }

        //public static void Save(int a = 3)
        //{

        //}
    }
}
