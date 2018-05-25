using System.Threading;
using System.Web.Http;

namespace MyAwesomeWebServer
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
           // ThreadPool.SetMaxThreads(1,1);
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
