using Dapr.Client;
using DaprNBlocks.Core.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Moq;
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

            _serviceProvider = services.BuildServiceProvider();
        }

        [TestMethod]
        public void GivenWhenHavingToLoadStateThenGetState()
        {
            
        }
    }
}