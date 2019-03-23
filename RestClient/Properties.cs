using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClient
{
    public static class Properties
    {
        public static string Api_key = "6ffdf6b7bcff69eaf5a9947f6734fe6b";
        public static string weatherPath = "data/2.5/forecast";
        public static string WeatherQuery = "q=Sydney,AUS&appid=6ffdf6b7bcff69eaf5a9947f6734fe6b";
        public static string BaseUrl = "https://samples.openweathermap.org/";
        public static int daysConsiderationForWeatherForecast = 5;
    }
}
