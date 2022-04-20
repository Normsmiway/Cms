using Cms.Api.Abstractions;

namespace Cms.Api.Core
{
    public abstract class BaseConsentOperation : IConsentOperation
    {
        public abstract ConsentDeliveryMechanism DeliveryMechanism { get; }
        protected abstract Task<ConsentResult> Consent(ConsentRequest request);
        public Task<ConsentResult> ExecuteAsync(ConsentRequest request)
        {
            return Consent(request);
        }
    }

    public interface IConsentOperation : IOperation<ConsentRequest, ConsentResult>
    {
        public abstract ConsentDeliveryMechanism DeliveryMechanism { get; }
    }
}
