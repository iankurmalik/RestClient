using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
namespace RestClient
{
    
    public class HttpRestClient:IRestClient
    {
       /// <summary>
       /// Method to get async results from WebAPI
       /// </summary>
       /// <param name="url"></param>
       /// <returns>respnseStream</returns>
        public string Get(Uri url)
        {
            using (var httpClient = new HttpClient())
            {
                var response = httpClient.GetStringAsync(url).Result;
                return response;
            }
        }
    }
}
