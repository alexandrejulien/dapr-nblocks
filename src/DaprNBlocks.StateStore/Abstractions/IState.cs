using System;
using System.Collections.Generic;
using System.Text;

namespace DaprNBlocks.StateStore.Abstractions
{
    internal interface IState<TState>
    {
        TState Get(string key);
        void Save(TState state);
    }
}
