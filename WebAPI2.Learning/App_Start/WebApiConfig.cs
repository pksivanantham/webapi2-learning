using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using WebAPI2.Learning.Filters;

namespace WebAPI2.Learning
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            var acceptedUrls = new EnableCorsAttribute(origins: "http://localhost:50524", headers: "*", methods: "PUT,GET,OPTIONS");

            config.EnableCors(acceptedUrls);

            config.Filters.Add(new CustomExceptionFilter());
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
