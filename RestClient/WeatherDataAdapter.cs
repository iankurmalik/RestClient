using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClient
{
    public class WeatherDataAdapter:IWeatherAdapter
    {
        IRestClient _restClient;
        public WeatherDataAdapter(IRestClient restClient)
        {
            _restClient = restClient;
        }
        public string GetWeatherData(Uri path)
        {
          string response=  _restClient.Get(path);
            return response;
        }
    }
}
