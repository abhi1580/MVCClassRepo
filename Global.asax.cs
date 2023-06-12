using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCActionResults
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            ViewEngines.Engines.Remove(ViewEngines.Engines.OfType<WebFormViewEngine>().FirstOrDefault());// remove WebFormViewEngine

            //Or 

            //ViewEngines.Engines.Clear(); //to clear all engines 
            //ViewEngines.Engines.Add(new RazorViewEngine()); //to set razor engine view engine as default
        }
    }
}
