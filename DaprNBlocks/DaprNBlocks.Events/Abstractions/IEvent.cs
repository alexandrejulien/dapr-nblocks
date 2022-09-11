using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaprNBlocks.Events.Abstractions
{
    public interface IEvent<T>
    {
        Guid Id { get; }
        string Name { get; }
        DateTime CreatedDate { get; }
        DateTime PublishedDate { get; set; }
        T Message { get; set; }
    }
}
