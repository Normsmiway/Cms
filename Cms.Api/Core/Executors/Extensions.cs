using Cms.Api.Abstractions;

namespace Cms.Api.Core.Executors
{
    public static class Extensions
    {
        public static IServiceCollection AddExecutors(this IServiceCollection services)
        {
            services.AddSingleton(typeof(IOperationExecutor<,>), typeof(OperationExecutor<,>));
            return services;
        }
    }
}
