using DaprNBlocks.Core.Abstractions;
using DaprNBlocks.Events.Abstractions;
using MediatR;

namespace DaprNBlocks.Events
{
    /// <summary>
    /// Event base structure.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="DaprNBlocks.Events.Abstractions.IEvent" />
    public class Event : IEvent, IRequest<EventStatus>
    {
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public Guid Id { get; }
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; }
        /// <summary>
        /// Gets the created date.
        /// </summary>
        /// <value>
        /// The created date.
        /// </value>
        public DateTime CreatedDate { get; }
        /// <summary>
        /// Gets or sets the published date.
        /// </summary>
        /// <value>
        /// The published date.
        /// </value>
        public DateTime PublishedDate { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Event{T}"/> class.
        /// </summary>
        public Event()
        {
            Id = Guid.NewGuid();
            Name = this.GetType().Name;
            CreatedDate = DateTime.Now;
        }
    }
}
