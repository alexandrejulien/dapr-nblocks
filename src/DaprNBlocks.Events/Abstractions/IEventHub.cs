using DaprNBlocks.Core.Abstractions;

namespace DaprNBlocks.Events.Abstractions
{
    /// <summary>
    /// Event Interface
    /// </summary>
    public interface IEventHub
    {
        void Publish(Event busEvent);
        Task PublishAsync(Event busEvent);
        Task Handle<TEvent>(TEvent busEvent) where TEvent : Event;
    }
}