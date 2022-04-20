using Cms.Api.Abstractions;

namespace Cms.Api.Core
{
    public abstract  class ConsentRequest : IOperationRequest<ConsentResult>
    {
        public ConsentDeliveryMechanism DeliveryMechanism { get; set; } = ConsentDeliveryMechanism.Deferred;
    }
    public abstract class ConsentResult
    {

    }
    public enum ConsentDeliveryMechanism
    {
        Deferred,
        Instant
    }
}
