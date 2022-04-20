namespace Cms.Api.Core
{
    
    /// <summary>
    /// Consent Delivery is deferred until later
    /// </summary>
    public class DeferredDeliveryConsentOperation : BaseConsentOperation
    {
        public override ConsentDeliveryMechanism DeliveryMechanism => ConsentDeliveryMechanism.Deferred;

        protected async override Task<ConsentResult> Consent(ConsentRequest request)
        {
            return await Task.FromResult(new DeferredDeliveryConsentResult());
        }
    }

    public class DeferredDeliveryConsentResult : ConsentResult { }
   
}
