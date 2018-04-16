using System.Web.Http;

namespace MyAwesomeWebServer
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            // Web API routes
            config.MapHttpAttributeRoutes();

        }
    }
}
