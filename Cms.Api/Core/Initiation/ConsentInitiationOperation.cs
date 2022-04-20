using Cms.Api.Abstractions;

namespace Cms.Api.Core.Initiation
{
    public interface IConsentInitiationOperation : IOperation<ConsentInitiationRequest, ConsentInitiationResult>
    {
        public string OperationType { get; }
    }
    public abstract class ConsentInitiationOperation : IConsentInitiationOperation
    {
        public abstract string OperationType { get; }

        protected abstract Task<ConsentInitiationResult> InitiateAsync(ConsentInitiationRequest request);
        public Task<ConsentInitiationResult> ExecuteAsync(ConsentInitiationRequest request)
        {
            return InitiateAsync(request);
        }
    }



}
