using DaprNBlocks.Events.Abstractions;
using DaprNBlocks.Events.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaprNBlocks.Events.Tests.Events
{
    public class TestEvent
        : Event, IRequest<EventStatus>
    {
        public new string Name = "It's fun";
        public double Value = 4.3401;
    }
}
