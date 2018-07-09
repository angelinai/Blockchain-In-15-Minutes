using BlockchainIn15Minutes.Interfaces;
using BlockchainIn15Minutes.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BlockchainIn15Minutes
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            //services.AddTransient<ICountryService, CountryService>();
            // and a lot more Services

            services.AddLogging()
                .AddSingleton<IHasherService, HasherService>()
                //.AddSingleton<IChain, ConveyorBeltChainEngine>()
                ;

            return services;
        }
    }
}