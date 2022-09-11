using DaprNBlocks.Core.Abstractions;

namespace DaprNBlocks.Events.Abstractions
{
    /// <summary>
    /// Event Interface
    /// </summary>
    public interface IEventHandler
    {
        void Publish<T>(IEvent<T> busEvent);
        Task PublishAsync<T>(IEvent<T> busEvent);
    }
}