using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Example01
{
    public class MvcApplication : System.Web.HttpApplication
    {
        //yazsanýzda yazmasanýzda çalýþan bazý metodlar var. Gidin araþtýrýn. 3.ödev.
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            //þüphe
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
