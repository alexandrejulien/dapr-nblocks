using Microsoft.Extensions.DependencyInjection;

namespace DaprNBlocks.Web.Extensions
{
    /// <summary>
    /// Building blocks extensions for dependency injection.
    /// </summary>
    public static class BuildingBlocksExtensions
    {
        /// <summary>
        /// Adds the building blocks.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <returns></returns>
        public static IServiceCollection AddDaprNBlocks(
            this IServiceCollection services)
        {
            services.AddDaprClient();
            return services;
        }
    }
}