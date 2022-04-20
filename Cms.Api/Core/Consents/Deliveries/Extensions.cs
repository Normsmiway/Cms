namespace Cms.Api.Core.Consents.Deliveries
{
    public static class Extensions
    {
        public static IServiceCollection AddConsentDelivery(this IServiceCollection services)
        {
            services.AddScoped<IConsentDeliveryOperation, ApiConsentDelivery>();
            services.AddScoped<IConsentDeliveryOperation, SmsConsentDelivery>();
            services.AddScoped<IConsentDeliveryOperation, EmailConsentDelivery>();

            return services;
        }
    }
}
