using Cms.Api.Core.Completion;

namespace Cms.Api.Core.Initiation
{
    public interface IConsentService
    {
        public Task<ConsentInitiationResult> InitiateAsync(ConsentInitiationRequest request);
        public Task<ConsentCompletionResult> CompleteAsync(ConsentCompletionRequest request);
    }


    public class ConsentService : IConsentService
    {
        private readonly ConsentInitiator _initiator;
        private readonly ConsentCompleter _completer;
        public ConsentService(ConsentCompleter completer, ConsentInitiator initiator)
        {
            _completer = completer;
            _initiator = initiator;
        }
        public Task<ConsentInitiationResult> InitiateAsync(ConsentInitiationRequest request)
        {
           return _initiator.InitiateAsync(request);
        }
        public Task<ConsentCompletionResult> CompleteAsync(ConsentCompletionRequest request)
        {
            return _completer.CompleteAsync(request);
        }


    }
}
