using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ModelAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Serviços e configuração da API da Web

            // Rotas da API da Web
            config.MapHttpAttributeRoutes();
            var jsonFormater = GlobalConfiguration.Configuration.Formatters.JsonFormatter;
            var JsonFormater = config.Formatters.JsonFormatter;
            JsonFormater.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
