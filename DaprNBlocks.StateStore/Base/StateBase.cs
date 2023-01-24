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
    internal abstract class StateBase<TState> : IState<TState>
    {
        /// <summary>
        /// Gets the building blocks.
        /// </summary>
        /// <value>
        /// The building blocks.
        /// </value>
        private readonly IBuildingBlocks buildingBlocks;

        /// <summary>
        /// The state store name.
        /// </summary>
        private readonly string stateStoreName;

        public TState Get(string key) 
            => buildingBlocks.DaprClient.GetStateAsync<TState>(stateStoreName, key).Result;

        public void Save(TState state)
            => buildingBlocks.DaprClient.SaveStateAsync<TState>(
                stateStoreName, UniqueIdentifier.New(), state)
                .Wait();
        
    }
}
