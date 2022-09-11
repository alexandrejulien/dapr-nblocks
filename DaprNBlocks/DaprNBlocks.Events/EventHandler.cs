using DaprNBlocks.Core.Abstractions;
using DaprNBlocks.Events.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DaprNBlocks.Events
{
    /// <summary>
    /// Event.
    /// </summary>
    /// <seealso cref="DaprNBlocks.Events.Abstractions.IEventHandler" />
    public class EventHandler :
        IEventHandler
    {
        /// <summary>
        /// Gets the building blocks.
        /// </summary>
        /// <value>
        /// The building blocks.
        /// </value>
        private readonly IBuildingBlocks BuildingBlocks;

        /// <summary>
        /// The event bus.
        /// </summary>
        private readonly IEventBus EventBus;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventHandler"/> class.
        /// </summary>
        /// <param name="buildingBlocks">The building blocks.</param>
        public EventHandler(IBuildingBlocks buildingBlocks, IEventBus eventbus)
        {
            BuildingBlocks = buildingBlocks;
            EventBus = eventbus;
        }

        public Task PublishAsync<T>(IEvent<T> busEvent)
        {
            var client = BuildingBlocks.DaprClient;

            return client.PublishEventAsync<T>(
                    EventBus.PubSubName,
                    busEvent.Name,
                    busEvent.Message);
        }

        public void Publish<T>(IEvent<T> busEvent)
            => PublishAsync(busEvent).Wait();
    }
}
