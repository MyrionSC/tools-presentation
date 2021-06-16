using common.DTO;

namespace business_layer
{
    public interface IWeatherService
    {
        WeatherDTO GetCurrentWeather();
    }
}