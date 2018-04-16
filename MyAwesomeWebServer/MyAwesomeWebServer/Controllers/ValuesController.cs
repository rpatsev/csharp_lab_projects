using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace MyAwesomeWebServer.Controllers
{
    [RoutePrefix("api/values")]
    public class ValuesController : ApiController
    {
        // GET api/values
        [Route]
        public async Task<string> GetAsync()
        {
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync("https://google.com");

                return await result.Content.ReadAsStringAsync();             
            }
        }

        [Route("sync")]
        public string Get()
        {
            using (var httpClient = new HttpClient())
            {
                return httpClient
                    .GetAsync("https://google.com")
                    .Result
                    .Content
                    .ReadAsStringAsync()
                    .Result;
            }
        }
    }
}
