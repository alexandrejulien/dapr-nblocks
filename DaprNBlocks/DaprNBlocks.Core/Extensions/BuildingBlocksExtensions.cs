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
        /// Adds the building blocks.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <returns></returns>
        public static IServiceCollection AddBuildingBlocks(
            this IServiceCollection services)
        {
            services.AddSingleton<IBuildingBlocks, BuildingBlocks>();
            return services;
        }
    }
}
