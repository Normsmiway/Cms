namespace Cms.Api.Core.Consents.Deliveries
{
    public sealed class ConsentSender
    {
        public static async Task<ConsentDeliveryResult> DeliverAsync(ConsentDeliveryRequest request)
        {
            ConsentDeliveryResult result = null;
            using (var scope = ServiceCompositionRoot.BeginLifetimeScope())
            {
                var senders = scope.ServiceProvider.GetServices<IConsentDeliveryOperation>();

                foreach (var delivery in request.ConsentRequest.DeliveryMechansims)
                {
                    var sender = senders?.FirstOrDefault(c => string.Equals(c.DeliveryType, delivery.ToString(), StringComparison.OrdinalIgnoreCase));
                    result = await sender?.ExecuteAsync(request);
                }

                return result;
            }
        }
    }

    public sealed class ConsentDeliveryFactory
    {
        public static ConsentDeliveryRequest Create(ConsentRequest consent)
        {
            return consent.DeliveryMechanism switch
            {
                ConsentDeliveryMechanism.Api => new ApiConsentDeliveryRequest() { CallbackUrl = "" },
                ConsentDeliveryMechanism.Email => new EmailConsentDeliveryRequest()
                {
                },
                ConsentDeliveryMechanism.Sms => new SmsConsentDeliveryRequest()
                {
                },
                _ => null,
            };
        }
    }
}
