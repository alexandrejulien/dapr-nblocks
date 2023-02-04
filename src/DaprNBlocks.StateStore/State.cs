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
    /// State.
    /// </summary>
    /// <typeparam name="TState">The type of the state.</typeparam>
    /// <seealso cref="DaprNBlocks.StateStore.Base.StateBase&lt;TState&gt;" />
    public class State<TState> : StateBase<TState>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="State{TState}"/> class.
        /// </summary>
        /// <param name="buildingBlocks">The building blocks.</param>
        public State(IBuildingBlocks buildingBlocks) 
            : base (buildingBlocks, StateType.Default)
        {

        }
    }
}
