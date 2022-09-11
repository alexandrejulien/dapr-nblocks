using DaprNBlocks.Core.Abstractions;
using DaprNBlocks.Events.Abstractions;

namespace DaprNBlocks.Events
{
    public class Event<T> : IEvent
    {
        public Guid Id { get; }
        public string Name { get; }
        public DateTime CreatedDate { get; }
        public DateTime PublishedDate { get; set; }

        public Event()
        {
            Id = Guid.NewGuid();
            Name = typeof(T).Name;
            CreatedDate = DateTime.Now;
        }
    }
}
