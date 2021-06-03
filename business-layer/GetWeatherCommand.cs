using System;

namespace business_layer
{
    public class GetWeatherCommand
    {
        private readonly IWeatherService _weatherService;

        public GetWeatherCommand(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        public void Execute()
        {
            Console.WriteLine("execute weather command");
        }
    }
}
