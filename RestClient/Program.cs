using Newtonsoft.Json.Linq;
using RestClient.Model;
using RestClient.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IRestClient client = new HttpRestClient();
                //This will come from DI in real world 
                IWeatherAdapter _weaterAdapter = new WeatherDataAdapter(client);
                //Comment end
                UriBuilder builder = new UriBuilder();
                UriBuilderRest objbuilder = new UriBuilderRest();
                builder = objbuilder.UriBuilder();               
                var json = _weaterAdapter.GetWeatherData(builder.Uri);
                JObject jsonObj = JObject.Parse(json);
                var list = from c in jsonObj["list"]
                           select c;
                Utility.PrintOutput(list);     
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}
