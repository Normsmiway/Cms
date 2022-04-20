namespace Cms.Api.Core.Consents.Deliveries
{
    public sealed class SmsConsentDelivery : IConsentDeliveryOperation
    {
        public string DeliveryType => "Sms";
        public Task<ConsentDeliveryResult> ExecuteAsync(ConsentDeliveryRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
