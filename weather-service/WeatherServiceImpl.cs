using System.Net.Http;
using business_layer;
using common.DTO;

namespace console
{
    public class WeatherServiceImpl : IWeatherService
    {
        private readonly HttpClient _client;

        public WeatherServiceImpl()
        {
            _client = SetupYrHttpClient();
        }

        public WeatherDTO GetCurrentWeather()
        {
            return new WeatherDTO {
                DegreesCelsius = 20
            };
        }
        
        private HttpClient SetupYrHttpClient()
        {
            return new HttpClient();
        }
    }
}