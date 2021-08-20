using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Web.Http;

namespace WebApplication1
{
    public class ValuesController1 : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        public static async Task<dynamic> makeRequest(string url)
        {
            var client = new HttpClient();
            var result = await client.GetStringAsync(url);
            dynamic json = JsonConvert.DeserializeObject(result);
            return json;

        }


        // GET api/<controller>/5
        public static async Task<string> GetAsync(int id)
        {
            dynamic response = await ValuesController1.makeRequest("http://api.springernature.com/openaccess/json?q=subject:Chemistry&api_key=1fa67c2b3227499ff5ce1a7f05b2fa21");
            Console.WriteLine(response);
            return null;
        }

        
    }
}