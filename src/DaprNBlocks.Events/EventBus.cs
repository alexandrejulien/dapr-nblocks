using DaprNBlocks.Events.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaprNBlocks.Events
{
    public class EventBus
        : IEventBus
    {
        public string PubSubName { get; }

        public EventBus(string pubsubname)
        {
            PubSubName = pubsubname;
        }
    }
}
