using Dapr.Client;

namespace DaprNBlocks.Core.Abstractions
{
    /// <summary>
    /// Interface Building blocks.
    /// </summary>
    public interface IBuildingBlocks
    {
        /// <summary>
        /// Gets the dapr client.
        /// </summary>
        /// <value>
        /// The dapr client.
        /// </value>
        DaprClient DaprClient { get; }
    }
}