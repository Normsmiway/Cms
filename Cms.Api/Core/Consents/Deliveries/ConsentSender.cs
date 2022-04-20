namespace Cms.Api.Core.Consents.Deliveries
{
    public sealed class ConsentSender
    {
        public static Task<ConsentDeliveryResult> DeliverAsync(ConsentDeliveryRequest request)
        {
            using (var scope = ServiceCompositionRoot.BeginLifetimeScope())
            {
                var senders = scope.ServiceProvider.GetServices<IConsentDeliveryOperation>();
                var sender = senders?.FirstOrDefault(c => string.Equals(c.DeliveryType,
                     request.DeliveryType, StringComparison.OrdinalIgnoreCase));
                if (sender == null)
                    throw new InvalidOperationException("Invalid delivery request");

                return sender.ExecuteAsync(request);
            }
        }
    }

    public sealed class ConsentDeliveryFactory
    {
        public static ConsentDeliveryRequest Create(ConsentRequest consent)
        {
            return consent.DeliveryMechanism switch
            {
                ConsentDeliveryMechanism.Api => new ApiConsentDeliveryRequest() {CallbackUrl="" },
                ConsentDeliveryMechanism.Email => new EmailConsentDeliveryRequest() { },
                ConsentDeliveryMechanism.Sms => new SmsConsentDeliveryRequest() { },
                _ => null,
            };
        }
    }
}
