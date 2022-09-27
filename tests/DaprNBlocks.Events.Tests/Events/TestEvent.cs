using DaprNBlocks.Events.Models;
using MediatR;

namespace DaprNBlocks.Events.Tests.Events
{
    public class TestEvent
        : Event, IRequest<EventStatus>
    {
        public new string Name = "It's fun";
        public double Value = 4.3401;
    }
}