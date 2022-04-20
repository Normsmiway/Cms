using Cms.Api.Core;
using Cms.Api.Core.Completion;
using Cms.Api.Core.Initiation;
using Cms.Api.UseCases.Balances;
using Cms.Api.UseCases.Balances.Completion;

namespace Cms.Api.UseCases
{
    public static class Extensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            //register core services
            services.AddCore();
            services.AddScoped<IConsentService, ConsentService>(); 

            //register use cases for balance requiry
            services.AddTransient<IConsentInitiationOperation, BalanceConsentInitiationOperation>();
            services.AddTransient<IConsentCompletionOperation, BalanceConsentCompletionOperation>();

            //resiter others use cases services
            return services;
        }
    }
}
