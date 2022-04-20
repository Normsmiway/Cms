using Cms.Api.Abstractions;

namespace Cms.Api.Core.Consents.Deliveries
{
    public interface IConsentDeliveryOperation : IOperation<ConsentDeliveryRequest, ConsentDeliveryResult>
    {
        public  string DeliveryType { get;}
    }
    internal abstract class ConsentDeliveryOperation : IConsentDeliveryOperation
    {
        public abstract string DeliveryType { get; }
        protected abstract Task<ConsentDeliveryResult> DeliverAsync(ConsentDeliveryRequest request);
        public Task<ConsentDeliveryResult> ExecuteAsync(ConsentDeliveryRequest request)
        {
            return DeliverAsync(request);
        }
    }
}
