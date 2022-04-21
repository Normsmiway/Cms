using Cms.Api.Abstractions;

namespace Cms.Api.Core.Consents.Deliveries
{
    public abstract class ConsentDeliveryRequest : IOperationRequest<ConsentDeliveryResult>
    {
        public abstract string DeliveryType { get; }
        public ConsentRequest ConsentRequest { get; set; }
    }

    public abstract class ConsentDeliveryResult { }
}
