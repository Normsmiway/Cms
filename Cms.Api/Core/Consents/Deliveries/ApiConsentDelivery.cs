namespace Cms.Api.Core.Consents.Deliveries
{
    public sealed class ApiConsentDelivery : IConsentDeliveryOperation
    {
        public string DeliveryType => "API";

        public Task<ConsentDeliveryResult> ExecuteAsync(ConsentDeliveryRequest request)
        {
            throw new NotImplementedException();
        }
    }


    
}
