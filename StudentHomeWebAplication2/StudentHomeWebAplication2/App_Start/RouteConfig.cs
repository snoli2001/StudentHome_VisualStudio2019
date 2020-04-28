using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace StudentHomeWebAplication2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            routes.MapRoute(
               name: "LandingPageRoute",
               url: "",
               defaults: new { controller = "Home", action = "LandingPage" }
           );
            routes.MapRoute(
                name: "LoginRoute",
                url: "Ingresar",
                defaults: new { controller = "Student", action = "Login" }
            );

            routes.MapRoute(
                name: "RegisterRoute",
                url: "RegistrarNuevoUsuario",
                defaults: new { controller = "Student", action = "Register" }
            );

           

        }
    }
}
