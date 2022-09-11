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

namespace DaprNBlocks.Events.Extensions
{
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
            services.AddTransient<IEventHandler, EventHandler>();
            services.AddSingleton<IEventBus>(new EventBus(pubsub));
            return services;
        }
    }
}
