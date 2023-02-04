using Dapr.Client;
using Dapr.Client.Autogen.Grpc.v1;
using DaprNBlocks.Core.Abstractions;
using DaprNBlocks.Core.Helpers;
using DaprNBlocks.StateStore.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DaprNBlocks.StateStore.Base
{
    public abstract class StateBase<TState> : IState<TState>
    {
        /// <summary>
        /// Gets the building blocks.
        /// </summary>
        /// <value>
        /// The building blocks.
        /// </value>
        protected readonly IBuildingBlocks buildingBlocks;

        /// <summary>
        /// The state store name.
        /// </summary>
        protected readonly string stateStoreName;

        /// <summary>
        /// Initializes a new instance of the <see cref="StateBase{TState}"/> class.
        /// </summary>
        /// <param name="buildingBlocks">The building blocks.</param>
        /// <param name="stateStoreName">Name of the state store.</param>
        protected StateBase(IBuildingBlocks buildingBlocks, string stateStoreName)
        {
            this.buildingBlocks = buildingBlocks;
            this.stateStoreName = stateStoreName;
        }

        /// <summary>
        /// Gets the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public TState Get(string key) 
            => buildingBlocks.DaprClient.GetStateAsync<TState>(stateStoreName, key).Result;

        /// <summary>
        /// Saves the specified state.
        /// </summary>
        /// <param name="state">The state.</param>
        public void Save(TState state)
            => buildingBlocks.DaprClient.SaveStateAsync<TState>(
                stateStoreName, UniqueIdentifier.New(), state)
                .Wait();
        
    }
}
