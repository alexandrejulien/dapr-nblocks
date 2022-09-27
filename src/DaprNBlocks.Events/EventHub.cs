using DaprNBlocks.Core.Abstractions;
using DaprNBlocks.Events.Abstractions;
using DaprNBlocks.Events.Models;
using MediatR;

namespace DaprNBlocks.Events
{
    /// <summary>
    /// Event.
    /// </summary>
    /// <seealso cref="DaprNBlocks.Events.Abstractions.IEventHandler" />
    public class EventHub :
        IEventHub
    {
        /// <summary>
        /// Gets the building blocks.
        /// </summary>
        /// <value>
        /// The building blocks.
        /// </value>
        private readonly IBuildingBlocks buildingBlocks;

        /// <summary>
        /// The event bus.
        /// </summary>
        private readonly IEventBus eventBus;

        /// <summary>
        /// The mediator
        /// </summary>
        private readonly IMediator mediator;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventRequestHandler"/> class.
        /// </summary>
        /// <param name="buildingBlocks">The building blocks.</param>
        public EventHub(IBuildingBlocks buildingBlocks, IEventBus eventbus, IMediator mediator)
        {
            this.buildingBlocks = buildingBlocks;
            this.eventBus = eventbus;
            this.mediator = mediator;
        }

        /// <summary>
        /// Publishes the asynchronous event.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="busEvent">The bus event.</param>
        /// <returns>Task.</returns>
        public Task PublishAsync(Event busEvent)
        {
            var client = buildingBlocks.DaprClient;
            busEvent.PublishedDate = DateTime.Now;

            return client.PublishEventAsync(
                    eventBus.PubSubName,
                    busEvent.Name,
                    busEvent,
                    CancellationToken.None);
        }

        /// <summary>
        /// Notifies the status.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id">The identifier.</param>
        /// <param name="status">The status.</param>
        /// <returns></returns>
        //public Task NotifyStatus<TEvent>(Guid id, EventStatus status)
        //    where TEvent : Event
        //{
        //    var client = buildingBlocks.DaprClient;
        //    var notif = new EventNotification<TEvent>(id, status);

        //    return client.PublishEventAsync<EventNotification<TEvent>>(
        //            eventBus.PubSubName,
        //            notif.Name,
        //            notif,
        //            CancellationToken.None);
        //}

        /// <summary>
        /// Handles the specified bus event.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="busEvent">The bus event.</param>
        /// <returns></returns>
        public Task Handle<TEvent>(TEvent busEvent) where TEvent : Event
            => mediator.Send(busEvent);

        /// <summary>
        /// Publishes the specified bus event.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="busEvent">The bus event.</param>
        public void Publish(Event busEvent)
            => PublishAsync(busEvent).Wait();
    }
}