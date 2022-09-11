using DaprNBlocks.Core.Abstractions;
using DaprNBlocks.Core.Extensions;
using DaprNBlocks.Events.Abstractions;
using DaprNBlocks.Events.Tests.Events;
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
            services.AddTransient<IEventHandler, EventHandler>();
            services.AddSingleton<IEventBus>(new EventBus("mybus"));
            _serviceProvider = services.BuildServiceProvider();
        }

        [TestMethod]
        public void GivenBuildingBlocksThenPublishEvent()
        {
            var buildingBlocks = _serviceProvider.GetRequiredService<IBuildingBlocks>();
            var eventHandler = _serviceProvider.GetRequiredService<IEventHandler>();
            Check.That(buildingBlocks).IsNotNull();
            Check.That(eventHandler).IsNotNull();

            var myEvent = new TestEvent();
            eventHandler.Publish(myEvent);
            
        }
    }
}