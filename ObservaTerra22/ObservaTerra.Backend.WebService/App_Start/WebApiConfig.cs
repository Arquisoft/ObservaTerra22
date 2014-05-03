using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ObservaTerra.Backend.WebService
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "IndicatorSearch",
                routeTemplate: "api/indicator/{token}/{partialname}",
                defaults: new { controller = "Indicator", token = RouteParameter.Optional, partialname = RouteParameter.Optional }
            );

        }
    }
}
