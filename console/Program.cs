using System;
using System.Net.Http;
using System.Threading;
using business_layer;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            IWeatherService weatherService = new WeatherServiceImpl();

            var cmd = new GetWeatherCommand(weatherService);

            while (true) {
                cmd.Execute();
                Thread.Sleep(1000 * 10);
            }
        }
    }
}
