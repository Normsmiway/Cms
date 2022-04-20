using Cms.Api.Abstractions;

namespace Cms.Api.Core.Completion
{
    public abstract class ConsentCompletionRequest : IOperationRequest<ConsentCompletionResult>
    {
        public abstract string RequestType { get; }
    }
}
