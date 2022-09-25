using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaprNBlocks.Events
{
    public class EventNotification<TEvent>
    {
        public Guid Id { get; set; }
        public EventStatus Status { get; set; }

        public string Name { get; set; }

        public EventNotification(Guid id, EventStatus status)
        {
            Id = id;
            Status = status;
            Name = typeof(TEvent).Name;
        }
    }
}
