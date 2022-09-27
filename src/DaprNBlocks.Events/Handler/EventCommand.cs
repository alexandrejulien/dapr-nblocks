using DaprNBlocks.Events.Abstractions;
using DaprNBlocks.Events.Models;
using MediatR;

namespace DaprNBlocks.Events.Handler
{
    /// <summary>
    /// Event Request Handler.
    /// </summary>
    /// <typeparam name="TEvent">The type of the event.</typeparam>
    /// <seealso cref="IRequestHandler&lt;TEvent, EventStatus&gt;" />
    public abstract class EventCommand<TEvent>
        : IRequestHandler<TEvent, EventStatus>
        where TEvent : Event
    {
        /// <summary>
        /// The hub
        /// </summary>
        private readonly IEventHub hub;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventCommand{TEvent}"/> class.
        /// </summary>
        /// <param name="hub">The hub.</param>
        protected EventCommand(IEventHub hub)
        {
            this.hub = hub;
        }

        /// <summary>
        /// Handles the specified request event.
        /// </summary>
        /// <param name="request">The request event.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public Task<EventStatus> Handle(TEvent request, CancellationToken cancellationToken)
        {
            //var notif = hub.NotifyStatus<TEvent>(request.Id, status);
            return Run(request, cancellationToken);
        }

        /// <summary>
        /// Runs the specified request event.
        /// </summary>
        /// <param name="requestEvent">The request event.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public abstract Task<EventStatus> Run(TEvent requestEvent, CancellationToken cancellationToken);
    }
}