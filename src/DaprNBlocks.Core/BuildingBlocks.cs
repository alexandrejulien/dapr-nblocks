using Dapr.Client;
using DaprNBlocks.Core.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace DaprNBlocks.Core
{
    /// <summary>
    /// Building blocks implementation.
    /// </summary>
    /// <seealso cref="DaprNBlocks.Core.Abstractions.IBuildingBlocks" />
    public class BuildingBlocks
        : IBuildingBlocks,
          IDisposable
    {
        /// <summary>
        /// Gets the dapr client.
        /// </summary>
        /// <value>
        /// The dapr client.
        /// </value>
        public DaprClient DaprClient { get; }

        /// <summary>
        /// The service provider.
        /// </summary>
        private readonly IServiceProvider provider;

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingBlocks"/> class.
        /// </summary>
        /// <param name="provider">The provider.</param>
        public BuildingBlocks(IServiceProvider provider)
        {
            this.provider = provider;
            DaprClient = provider.GetRequiredService<DaprClient>();
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            DaprClient.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}