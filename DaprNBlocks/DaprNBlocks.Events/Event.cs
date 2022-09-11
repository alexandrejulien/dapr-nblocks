using DaprNBlocks.Core.Abstractions;
using DaprNBlocks.Events.Abstractions;

namespace DaprNBlocks.Events
{
    public class Event<T> : IEvent<T>
    {
        public Guid Id { get; }
        public string Name { get; }
        public DateTime CreatedDate { get; }
        public DateTime PublishedDate { get; set; }
        public T Message { get ; set ; }

        public Event()
        {
            Id = Guid.NewGuid();
            DateTime createdDate = DateTime.Now;
            Name = typeof(T).Name;
        }
    }
}
