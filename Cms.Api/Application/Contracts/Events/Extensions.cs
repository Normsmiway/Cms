using Cms.Api.Core.Bus;

namespace Cms.Api.Application.Contracts.Events
{
    public static class Extensions
    {
        public static IServiceCollection AddEvents(this IServiceCollection services)
        {
            services.AddSingleton<IEventBus, InMemoryEventBus>();
            return services;
        }
    }
}
