using DaprNBlocks.Events.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaprNBlocks.Events.Tests.Events
{
    internal class TestEvent
        : Event<TestEvent>
    {
        public new string Name = "It's fun";
        public double Value = 4.3401;
    }
}
