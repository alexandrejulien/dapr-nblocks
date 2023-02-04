using DaprNBlocks.Core;
using DaprNBlocks.Core.Abstractions;
using DaprNBlocks.StateStore;
using DaprNBlocks.StateStore.Abstractions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace DaprNBlocks.Events.Extensions
{
    /// <summary>
    /// Extensions for DI.
    /// </summary>
    public static class BuildingBlockStateStore
    {
        /// <summary>
        /// Adds the building blocks.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <returns></returns>
        public static IServiceCollection AddStateStore(
            this IServiceCollection services)
        {
            services.AddMediatR(typeof(Mediator));
            services.TryAddSingleton<IBuildingBlocks, BuildingBlocks>();
            return services;
        }

        /// <summary>
        /// Registers the state.
        /// </summary>
        /// <typeparam name="TState">The type of the state.</typeparam>
        /// <param name="services">The services.</param>
        /// <returns></returns>
        public static IServiceCollection RegisterState<TState>(this IServiceCollection services)
        {
            services.AddTransient<State<TState>>();
            return services;
        }

        /// <summary>
        /// Registers the shared sate.
        /// </summary>
        /// <typeparam name="TState">The type of the state.</typeparam>
        /// <param name="services">The services.</param>
        /// <returns></returns>
        public static IServiceCollection RegisterSharedSate<TState>(this IServiceCollection services)
        {
            services.AddTransient<SharedState<TState>>();
            return services;
        }
    }
}