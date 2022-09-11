using DaprNBlocks.Core.Abstractions;
using DaprNBlocks.Core.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace DaprNBlocks.Events.Tests
{
    [TestClass]
    public class EventTests
    {
        private readonly IServiceProvider _serviceProvider;

        public EventTests()
        {
            ServiceCollection services = new ServiceCollection();

            services.AddBuildingBlocks();

            _serviceProvider = services.BuildServiceProvider();
        }

        [TestMethod]
        public void GivenBuildingBlocksThenPublishEvent()
        {
            Check.That(_serviceProvider.GetRequiredService<IBuildingBlocks>()).IsNotNull();
        }
    }
}