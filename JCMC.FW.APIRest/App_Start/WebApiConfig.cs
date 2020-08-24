using JCMC.FW.APIRest.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using System.Web.Http;
using System.Web.Http.Cors;

namespace JCMC.FW.APIRest
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web

            // Rutas de API web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            /*JSON*/
            //Evito las referencias circulares al trabajar con Entity FrameWork         
            config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize;
            config.Formatters.JsonFormatter.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;

            //Elimino que el sistema devuelva en XML, sólo trabajaremos con JSON
            config.Formatters.Remove(GlobalConfiguration.Configuration.Formatters.XmlFormatter);

            var cors = new EnableCorsAttribute("http://localhost:4201", "*", "*");
            config.EnableCors(cors);           
        }
    }
}
