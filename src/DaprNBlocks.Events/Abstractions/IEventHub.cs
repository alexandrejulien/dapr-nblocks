using DaprNBlocks.Core.Abstractions;
using DaprNBlocks.Events.Models;
using static Google.Rpc.Context.AttributeContext.Types;

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