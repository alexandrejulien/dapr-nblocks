using DaprNBlocks.Events.Abstractions;
using DaprNBlocks.Events.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DaprNBlocks.Events.Extensions
{
    /// <summary>
    /// Extensions for DI.
    /// </summary>
    public static class BuildingBlockEvents
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
            services.AddSingleton<IEventBus>(new EventBus(pubsub));
            services.AddTransient<IEventHub, EventHub>();
            return services;
        }
    }
}