using DaprNBlocks.Core.Abstractions;

namespace DaprNBlocks.Events.Abstractions
{
    /// <summary>
    /// Event Interface
    /// </summary>
    public interface IEventHandler
    {
        void Publish<T>(Event<T> busEvent);
        Task PublishAsync<T>(Event<T> busEvent);
    }
}