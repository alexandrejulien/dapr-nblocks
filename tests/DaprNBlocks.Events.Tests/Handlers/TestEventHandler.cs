using DaprNBlocks.Events.Abstractions;
using DaprNBlocks.Events.Handler;
using DaprNBlocks.Events.Models;
using DaprNBlocks.Events.Tests.Events;

namespace DaprNBlocks.Events.Tests.Handlers
{
    public class TestEventHandler : EventCommand<TestEvent>
    {
        public TestEventHandler(IEventHub handler) : base(handler)
        {
        }

        public override Task<EventStatus> Run(TestEvent request, CancellationToken cancellationToken)
        {
            Console.WriteLine("Here is make my event action");

            return Task.FromResult(EventStatus.Completed);
        }
    }
}