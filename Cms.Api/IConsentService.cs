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
        private readonly ConsentInitiationOperator _initiator;
        private readonly ConsentCompletionOperator _completer;
        public ConsentService(ConsentCompletionOperator completer, ConsentInitiationOperator initiator)
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
