using DaprNBlocks.Core.Abstractions;
using DaprNBlocks.Core.Extensions;
using DaprNBlocks.Web.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace DaprNBlocks.Web.Tests
{
    [TestClass]
    public class StartupTests
    {
        private readonly IServiceProvider _serviceProvider;

        public StartupTests()
        {
            ServiceCollection services = new();
            services.AddDaprNBlocks();
            services.AddBuildingBlocks();

            _serviceProvider = services.BuildServiceProvider();
        }

        [TestMethod]
        public void GivenAddDaprClientWhenStartupThenGetBuildingBlocks()
        {
            var client = _serviceProvider.GetRequiredService<IBuildingBlocks>();
            Check.That(client.DaprClient).IsNotNull();
        }
    }
}