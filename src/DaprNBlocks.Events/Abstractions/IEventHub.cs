using DaprNBlocks.Events.Models;

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

        //Task NotifyStatus<TEvent>(Guid id, EventStatus status) where TEvent : Event;
    }
}