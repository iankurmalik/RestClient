using RestClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClient.Utils
{
    public class UriBuilderRest
    {
        public UriBuilder UriBuilder()
        {
            UriBuilder builder = new UriBuilder(Properties.BaseUrl);
            builder.Path = Properties.weatherPath;
            builder.Query = Properties.WeatherQuery;
            return builder;
        }
    }
}
