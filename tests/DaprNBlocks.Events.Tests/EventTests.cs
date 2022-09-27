using Dapr.Client;
using DaprNBlocks.Core.Abstractions;
using DaprNBlocks.Core.Extensions;
using DaprNBlocks.Events.Abstractions;
using DaprNBlocks.Events.Extensions;
using DaprNBlocks.Events.Models;
using DaprNBlocks.Events.Tests.Events;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NFluent;

namespace DaprNBlocks.Events.Tests
{
    [TestClass]
    public class EventTests
    {
        private readonly IServiceProvider _serviceProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventTests"/> class.
        /// </summary>
        public EventTests()
        {
            ServiceCollection services = new();
            services.AddSingleton<DaprClient>(Mock.Of<DaprClient>());
            services.AddBuildingBlocks();
            services.AddEvents(pubsub: "mybus");
            services.AddMediatR(typeof(TestEvent), typeof(EventStatus));
            _serviceProvider = services.BuildServiceProvider();
        }

        [TestMethod]
        public void GivenBuildingBlocksThenPublishEvent()
        {
            var buildingBlocks = _serviceProvider.GetRequiredService<IBuildingBlocks>();
            var eventHandler = _serviceProvider.GetRequiredService<IEventHub>();
            Check.That(buildingBlocks).IsNotNull();
            Check.That(eventHandler).IsNotNull();

            var myEvent = new TestEvent();

            Check.That(myEvent.Id).IsInstanceOf<Guid>();
            Check.That(myEvent.Name).Contains("fun");
            Check.That(myEvent.CreatedDate).IsInstanceOf<DateTime>();

            eventHandler.Publish(myEvent);
        }

        [TestMethod]
        public void GivenEventWhenPublishingThenHandleEvent()
        {
            var handler = _serviceProvider.GetRequiredService<IEventHub>();
            var mock = new TestEvent() { Name = "Test", Value = 42.42 };

            Check.ThatCode(() =>
                 handler.Handle<TestEvent>(mock).Wait())
                .DoesNotThrow();
        }
    }
}