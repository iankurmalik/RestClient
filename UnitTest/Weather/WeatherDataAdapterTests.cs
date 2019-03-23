using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Moq;
using RestClient;
using Xunit;
namespace MoqUnitTest.Weather
{
    public class WeatherDataAdapterTests
    {
        [Fact]
        public void GetData_ShouldReturn_OK()
        {
            //Arrange
            string BaseUrl = "http://www.google.com/";
            Uri uri = new Uri(BaseUrl);
            Mock<IRestClient> mockHttpClient = new Mock<IRestClient>();
            mockHttpClient.Setup(r => r.Get(It.IsAny<Uri>())).Returns(GetSampleWeatherResponse);
            var objWeather = new WeatherDataAdapter(mockHttpClient.Object);
            //Act
            var result = objWeather.GetWeatherData(uri);
            //Assert
            Assert.NotEmpty(result);
        }

        private string GetSampleWeatherResponse()
        {
            string json = String.Empty;
            using (StreamReader r = new StreamReader("..\\..\\..\\..\\UnitTest\\Weather\\SampleWeatherData.json"))
            {
                 json= r.ReadToEnd();
            }
                return json;
        }
    }
}
