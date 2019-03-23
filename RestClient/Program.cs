using Newtonsoft.Json.Linq;
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
                int daysToConsider = 0;
                int temperatureOverTwentyDegrees = 0;
                string distinctDate = String.Empty;
                List<string> lstSunnyDays = new List<string>();
                List<string> lstTwentyDegreeAboveDays = new List<string>();
                //This will come from DI in real world 
                IWeatherAdapter _weaterAdapter = new WeatherDataAdapter(new HttpRestClient());
                //Comment end
                UriBuilder builder = new UriBuilder(Properties.BaseUrl);
                builder.Path = Properties.weatherPath;
                builder.Query = Properties.WeatherQuery;               
                var json = _weaterAdapter.GetWeatherData(builder.Uri);
                JObject jsonObj = JObject.Parse(json);
                //IList<JToken> results = jsonObj["list"].Children().ToList();
                var list = from c in jsonObj["list"]
                           select c;
                
                foreach (var data in list)
                {
                    if (String.IsNullOrEmpty(distinctDate))
                    {
                        distinctDate = Convert.ToDateTime(data["dt_txt"]).ToShortDateString();
                        daysToConsider++;
                    }
                    else
                    {
                        if (distinctDate == Convert.ToDateTime(data["dt_txt"]).ToShortDateString())
                        {
                            continue;
                        }
                        else
                        {
                            if (daysToConsider > Properties.daysConsiderationForWeatherForecast)
                            {
                                break;
                            }
                            distinctDate = Convert.ToDateTime(data["dt_txt"]).Date.ToShortDateString();
                            daysToConsider++;
                        }
                    }
                    var temp = data["main"]["temp"];
                    var weatherForecast = data["weather"][0]["icon"].ToString();
                    if (weatherForecast == "01d")
                    {

                        lstSunnyDays.Add(distinctDate);
                    }
                    if (temp != null && temp.ToString() != "")
                    {
                        var tempInDegrees = (Convert.ToDouble(temp) - 273.15);
                        if (tempInDegrees >= 20)
                        {
                            temperatureOverTwentyDegrees++;
                            lstTwentyDegreeAboveDays.Add(distinctDate);
                        }
                    }
                }
                if(lstSunnyDays.Count>0)
                {
                    Console.WriteLine("Looks like we got sunny day(s) in next " +Properties.daysConsiderationForWeatherForecast+" days");
                    foreach (var date in lstSunnyDays)
                    {
                        Console.WriteLine(date + " " + Convert.ToDateTime(date).DayOfWeek);
                    }
                    Console.Read();

                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}
