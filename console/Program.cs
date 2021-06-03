using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting up...");
            AppStartup().Run();
        }
        
        static IHost AppStartup()
        {
            var builder = new ConfigurationBuilder();
            BuildConfig(builder);

            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {

                })
                .Build();

            return host;
        }
        
        static void BuildConfig(IConfigurationBuilder builder)
        {
            builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();
        }
    }
}
