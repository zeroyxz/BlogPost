using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace BlogPost
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes - attribute routing
            config.MapHttpAttributeRoutes();

            //Convention based routing
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
