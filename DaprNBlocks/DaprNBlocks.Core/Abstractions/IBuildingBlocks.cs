using Dapr.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
