using Cms.Api.Core.Completion;
using Cms.Api.Core.Consents;
using Cms.Api.Core.Executors;
using Cms.Api.Core.Initiation;

namespace Cms.Api.Core
{
    public static class Extensions
    {
        public static IServiceCollection AddCore(this IServiceCollection services)
        {
            services.AddConsent();
            services.AddExecutors();

            //Register operators
            services.AddSingleton<ConsentInitiationOperator>();
            services.AddSingleton<ConsentCompletionOperator>();

            return services;
        }
    }
}
