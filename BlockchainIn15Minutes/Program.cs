using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace BlockchainIn15Minutes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // setup our DI
            var services = new ServiceCollection();
            services.RegisterServices();

            // build service provider
            var serviceProvider = services.BuildServiceProvider();

            // add logging
            serviceProvider
                .GetService<ILoggerFactory>()
                .AddConsole(LogLevel.Debug);

            var logger = serviceProvider.GetService<ILoggerFactory>()
                .CreateLogger<Program>();

            logger.LogDebug("Starting blockchain application");

            var blockChain = new ConveyorBeltChainEngine(services);

            logger.LogDebug("Begin Start Chain!");

            blockChain.StartChain();

            logger.LogDebug("All done!");
            Console.ReadLine();
        }
    }
}