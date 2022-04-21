using Cms.Api.Core.Bus;
using Cms.Api.Core.Completion;
using Cms.Api.Core.Initiation;

namespace Cms.Api.Core
{
    public interface IConsentService
    {
        public Task<ConsentInitiationResult> InitiateAsync(ConsentInitiationRequest request);
        public Task<ConsentCompletionResult> CompleteAsync(ConsentCompletionRequest request);
    }


    public class ConsentService : IConsentService
    {
        private readonly ConsentInitiationOperator _initiator;
        private readonly IConsentOperation _consentOperation;
        private readonly ConsentCompletionOperator _completer;

        private readonly IEventBus _eventBus;
        public ConsentService(ConsentCompletionOperator completer, ConsentInitiationOperator initiator, IEventBus eventBus)
        {
            _completer = completer;
            _initiator = initiator;
            _eventBus = eventBus;
        }
        public async Task<ConsentInitiationResult> InitiateAsync(ConsentInitiationRequest request)
        {
            var result = await _initiator.InitiateAsync(request);

            await _consentOperation.ExecuteAsync(null);

            return result;
        }
        public async Task<ConsentCompletionResult> CompleteAsync(ConsentCompletionRequest request)
        {
            var result = await _completer.CompleteAsync(request);

            await _eventBus.PublishAsync<AfterConsent>(new AfterConsent(string.Empty, string.Empty));

            return result;
        }


    }
}
