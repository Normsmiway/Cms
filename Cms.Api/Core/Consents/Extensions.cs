using Cms.Api.Core.Consents.Deliveries;

namespace Cms.Api.Core.Consents
{

    public static class Extensions
    {
        public static IServiceCollection AddConsent(this IServiceCollection services)
        {

            services.AddScoped<IConsentOperation, InstantDeliveryConsentOperation>();
            services.AddScoped<IConsentOperation, DeferredDeliveryConsentOperation>();

            //register delivery mechanisms
            return services.AddConsentDelivery();
        }
    }
}
