using Cms.Api.Abstractions;

namespace Cms.Api.Core
{
    public abstract  class ConsentRequest : IOperationRequest<ConsentResult>
    {
        public ConsentDeliveryMechanism DeliveryMechanism { get; set; } = ConsentDeliveryMechanism.None;
    }
    public abstract class ConsentResult
    {

    }
    public enum ConsentDeliveryMechanism
    {
        None,
        Api,
        Email,
        Sms
    }
}
