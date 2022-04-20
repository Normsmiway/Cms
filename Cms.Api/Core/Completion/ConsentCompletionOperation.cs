using Cms.Api.Abstractions;

namespace Cms.Api.Core.Completion
{
    public interface IConsentCompletionOperation : IOperation<ConsentCompletionRequest, ConsentCompletionResult>
    {
        public string OperationType { get; }
    }
    public abstract class ConsentCompletionOperation : IConsentCompletionOperation
    {
        public abstract string OperationType { get; }
        protected abstract Task<ConsentCompletionResult> CompleteAsync(ConsentCompletionRequest request);
        public Task<ConsentCompletionResult> ExecuteAsync(ConsentCompletionRequest request)
        {
            return CompleteAsync(request);
        }
    }
}
