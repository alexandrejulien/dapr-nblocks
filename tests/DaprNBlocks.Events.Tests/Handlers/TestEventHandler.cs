using DaprNBlocks.Core.Abstractions;
using DaprNBlocks.Events.Abstractions;
using DaprNBlocks.Events.Tests.Events;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaprNBlocks.Events.Tests.Handlers
{
    public class TestEventHandler : EventRequestHandler<TestEvent>
    {
        public TestEventHandler(EventHub handler) : base(handler)
        {
        }

        public override EventStatus Run(TestEvent request, CancellationToken cancellationToken)
        {
            Console.WriteLine("Here is make my event action");

            return EventStatus.Completed;
        }
    }
}
