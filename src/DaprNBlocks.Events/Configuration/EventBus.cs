using DaprNBlocks.Events.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaprNBlocks.Events.Configuration
{
    /// <summary>
    /// Event Bus.
    /// </summary>
    /// <seealso cref="IEventBus" />
    public class EventBus
        : IEventBus
    {
        /// <summary>
        /// Gets or sets the name of the pub sub.
        /// </summary>
        /// <value>
        /// The name of the pub sub.
        /// </value>
        public string PubSubName { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventBus"/> class.
        /// </summary>
        /// <param name="pubsubname">The pubsubname.</param>
        public EventBus(string pubsubname)
        {
            PubSubName = pubsubname;
        }
    }
}
