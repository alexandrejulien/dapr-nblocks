using Microsoft.Extensions.DependencyInjection;
using Dapr.Client;
using static Dapr.Client.Autogen.Grpc.v1.Dapr;
using DaprNBlocks.Core.Abstractions;
using DaprClient = Dapr.Client.DaprClient;

namespace DaprNBlocks.Core.Extensions
{
    /// <summary>
    /// Dapr building blocks.
    /// </summary>
    public static class BuildingBlocksExtensions
    {
        /// <summary>
        /// Adds the yarp reverse proxy.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <returns></returns>
        public static IServiceCollection AddYarpReverseProxy(
            this IServiceCollection services)
        {
            var client = new DaprClientBuilder().Build();

            services.AddSingleton<DaprClient>(client);
            return services;
        }
    }
}
