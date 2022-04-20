namespace Cms.Api.Core
{
  
    /// <summary>
    /// Consent delivery is computed before operation is triggered
    /// </summary>
    public class InstantDeliveryConsentOperation : ConsentOperation
    {
        public override ConsentDeliveryMechanism DeliveryMechanism => ConsentDeliveryMechanism.Instant;
        //Post or compose delivery before initiating consent
        protected async override Task<ConsentResult> Consent(ConsentRequest request)
        {
            return await Task.FromResult(new InstantDeliveryConsentOperationResult());
        }
    }

    public  class InstantDeliveryConsentOperationResult : ConsentResult
    {

    }
}
