using DaprNBlocks.Events.Abstractions;
using Grpc.Core;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaprNBlocks.Events
{
    /// <summary>
    /// Event Request Handler.
    /// </summary>
    /// <typeparam name="TEvent">The type of the event.</typeparam>
    /// <seealso cref="MediatR.IRequestHandler&lt;TEvent, DaprNBlocks.Events.EventStatus&gt;" />
    public abstract class EventRequestHandler<TEvent> 
        : IRequestHandler<TEvent, EventStatus>
        where TEvent : Event
    {
        /// <summary>
        /// The hub
        /// </summary>
        private readonly EventHub hub;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventRequestHandler{TEvent}"/> class.
        /// </summary>
        /// <param name="hub">The hub.</param>
        protected EventRequestHandler(EventHub hub)
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
            var status = Run(request, cancellationToken);
            var notif = hub.NotifyStatus<TEvent>(request.Id, status);
            return (Task<EventStatus>)notif;
        }

        /// <summary>
        /// Runs the specified request event.
        /// </summary>
        /// <param name="requestEvent">The request event.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public abstract EventStatus Run(TEvent requestEvent, CancellationToken cancellationToken);
    }
}
