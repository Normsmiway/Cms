namespace Cms.Api.Core.Consents.Deliveries
{
    public sealed class EmailConsentDelivery : IConsentDeliveryOperation
    {
        public string DeliveryType => new EmailConsentDeliveryRequest().DeliveryType;
        public Task<ConsentDeliveryResult> ExecuteAsync(ConsentDeliveryRequest request)
        {
            throw new NotImplementedException();
        }
    }
    public class EmailConsentDeliveryRequest : ConsentDeliveryRequest
    {
        public override string DeliveryType => "Email";
    }
    public class EmailConsentDeliveryResult: ConsentDeliveryResult { }
}
