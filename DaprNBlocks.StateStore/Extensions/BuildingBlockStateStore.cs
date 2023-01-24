using DaprNBlocks.Core;
using DaprNBlocks.Core.Abstractions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace DaprNBlocks.Events.Extensions
{
    /// <summary>
    /// Extensions for DI.
    /// </summary>
    public static class BuildingBlockStateStore
    {
        /// <summary>
        /// Adds the building blocks.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <returns></returns>
        public static IServiceCollection AddEvents(
            this IServiceCollection services,
            string pubsub)
        {
            services.AddMediatR(typeof(Mediator));
            services.TryAddSingleton<IBuildingBlocks, BuildingBlocks>();
            return services;
        }
    }
}