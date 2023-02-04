using DaprNBlocks.Core.Abstractions;
using DaprNBlocks.StateStore.Base;
using DaprNBlocks.StateStore.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaprNBlocks.StateStore
{
    /// <summary>
    /// Shared State.
    /// This state is shared between all distributed applications.
    /// </summary>
    public class SharedState<TState> : StateBase<TState>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharedState{TState}"/> class.
        /// </summary>
        /// <param name="buildingBlocks">The building blocks.</param>
        public SharedState(IBuildingBlocks buildingBlocks) : base(buildingBlocks, StateType.Shared)
        {
        }
    }
}
