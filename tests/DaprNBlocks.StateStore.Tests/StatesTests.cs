using Castle.Components.DictionaryAdapter.Xml;
using Dapr.Client;
using DaprNBlocks.Core.Extensions;
using DaprNBlocks.Events.Extensions;
using DaprNBlocks.StateStore.Tests.Models;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using NFluent;
using System.Runtime.CompilerServices;

namespace DaprNBlocks.StateStore.Tests
{
    /// <summary>
    /// States.
    /// </summary>
    [TestClass]
    public class StatesTests
    {
        /// <summary>
        /// The service provider.
        /// </summary>
        private readonly IServiceProvider _serviceProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="StatesTests"/> class.
        /// </summary>
        public StatesTests()
        {
            ServiceCollection services = new();
            services.AddSingleton<DaprClient>(Mock.Of<DaprClient>());
            services.AddBuildingBlocks();
            services.AddStateStore();
            services.RegisterState<TestStateModel>();
            services.RegisterSharedSate<TestStateModel>();

            _serviceProvider = services.BuildServiceProvider();
        }

        [TestMethod]
        public void GivenWhenHavingToLoadStateThenGetState()
        {
            var currentState = _serviceProvider.GetService<State<TestStateModel>>();
            var id = Guid.NewGuid();
            var myObj = new TestStateModel() { Id = id, Name = "Test", Description = "Description" };

            Check.ThatCode(() => currentState.Save(myObj)).DoesNotThrow();

            Check.ThatCode(() => currentState.Get(id.ToString())).DoesNotThrow();
        }

        [TestMethod]
        public void GivenWhenHavingSharedStateThenCheck()
        {
            var currentState = _serviceProvider.GetService<SharedState<TestStateModel>>();
            var id = Guid.NewGuid();
            var myObj = new TestStateModel() { Id = id, Name = "Test", Description = "Description" };

            Check.ThatCode(() => currentState.Save(myObj)).DoesNotThrow();

            Check.ThatCode(() => currentState.Get(id.ToString())).DoesNotThrow();
        }
    }
}