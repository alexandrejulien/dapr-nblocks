using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaprNBlocks.Events.Abstractions
{
    /// <summary>
    /// IBus.
    /// </summary>
    public interface IEventBus
    {
        /// <summary>
        /// Gets or sets the name of the pub sub.
        /// </summary>
        /// <value>
        /// The name of the pub sub.
        /// </value>
        public string PubSubName { get; }
    }
}
