using Cms.Api.Core.Bus;
using Cms.Api.Core.Consents.Deliveries;

namespace Cms.Api.Core
{

    /// <summary>
    /// Consent delivery is computed before operation is triggered
    /// </summary>
    public class ConsentOperation : BaseConsentOperation
    {
        private readonly IEventBus _eventBus;
        public override ConsentDeliveryMechanism DeliveryMechanism => ConsentDeliveryMechanism.None;

        public ConsentOperation(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        //Post or compose delivery before initiating consent
        protected async override Task<ConsentResult> Consent(ConsentRequest request)
        {
            await _eventBus.PublishAsync<BeforeConsent>(new BeforeConsent("", request.DeliveryMechanism.ToString()));

            var result = await ConsentSender.DeliverAsync(ConsentDeliveryFactory.Create(request));
            if (result != null)
            {
                await _eventBus.PublishAsync<BeforeConsent>(new OnConsenting("", request.DeliveryMechanism.ToString()));
            }


            return InstantDeliveryConsentOperationResult.Default;
        }
    }

    public class InstantDeliveryConsentOperationResult : ConsentResult
    {
        public static readonly InstantDeliveryConsentOperationResult Default = new();
    }


    public class BeforeConentHandler
    {
        public async Task Handle(BeforeConsent consent)
        {
            //create virtual URL,
            await Task.CompletedTask;
        }
    }


    public class OnSendtingConentHandler
    {
        public async Task Handle(BeforeConsent consent)
        {
            //create virtual URL,
            await Task.CompletedTask;
        }
    }
}
