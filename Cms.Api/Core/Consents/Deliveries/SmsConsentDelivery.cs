namespace Cms.Api.Core.Consents.Deliveries
{
    public sealed class SmsConsentDelivery : IConsentDeliveryOperation
    {
        public string DeliveryType => new SmsConsentDeliveryRequest().DeliveryType;
        public Task<ConsentDeliveryResult> ExecuteAsync(ConsentDeliveryRequest request)
        {
            throw new NotImplementedException();
        }
    }


    public class SmsConsentDeliveryRequest : ConsentDeliveryRequest
    {
        public override string DeliveryType => ConsentDeliveryMechanism.Sms.ToString();
    }
}
