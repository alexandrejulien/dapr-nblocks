using Dapr.Client;
using DaprNBlocks.Core.Abstractions;
using DaprNBlocks.Core;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DaprNBlocks.Events.Abstractions;
using DaprNBlocks.Events.Configuration;

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
