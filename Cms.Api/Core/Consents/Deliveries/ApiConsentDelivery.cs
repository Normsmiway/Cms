namespace Cms.Api.Core.Consents.Deliveries
{
    public sealed class ApiConsentDelivery : IConsentDeliveryOperation
    {
        public string DeliveryType => new ApiConsentDeliveryRequest().DeliveryType;

        public Task<ConsentDeliveryResult> ExecuteAsync(ConsentDeliveryRequest request)
        {
            throw new NotImplementedException();
        }
    }

    public class ApiConsentDeliveryRequest: ConsentDeliveryRequest
    {
        public string CallbackUrl { get; set; }
        public string Data { get; set; }    
        public override string DeliveryType => ConsentDeliveryMechanism.Api.ToString();
    }


}
