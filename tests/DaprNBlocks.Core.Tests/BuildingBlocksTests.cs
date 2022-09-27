using Dapr.Client;
using DaprNBlocks.Core.Abstractions;
using DaprNBlocks.Core.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NFluent;

namespace DaprNBlocks.Core.Tests
{
    [TestClass]
    public class BuildingBlocksTests
    {
        private readonly IServiceProvider _serviceProvider;

        public BuildingBlocksTests()
        {
            ServiceCollection services = new();
            services.AddSingleton<DaprClient>(Mock.Of<DaprClient>());
            services.AddBuildingBlocks();

            _serviceProvider = services.BuildServiceProvider();
        }

        [TestMethod]
        public void GivenServicesThenGetBuildingBlocks()
        {
            var client = _serviceProvider.GetService<IBuildingBlocks>();
            Check.That(client).InheritsFrom<BuildingBlocks>();
        }

        [TestMethod]
        public void GivenServicesWhenDisposeThenThrowExceptions()
        {
            var client = (BuildingBlocks)_serviceProvider.GetService<IBuildingBlocks>();
            client.Dispose();
        }
    }
}