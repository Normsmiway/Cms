using Cms.Api.Abstractions;
using Cms.Api.Core.Executors;

namespace Cms.Api.Core.Completion
{
    public class ConsentCompletionOperator: OperatorBase<ConsentCompletionRequest, ConsentCompletionResult>
    {
        public ConsentCompletionOperator(IOperationExecutor<ConsentCompletionRequest, ConsentCompletionResult> exec) : base(exec)
        {
        }

        public Task<ConsentCompletionResult> CompleteAsync(ConsentCompletionRequest request)
        {
            return _exec.ExecuteAsync<IConsentCompletionOperation>(request, i
                => string.Equals(i.OperationType, request.RequestType, StringComparison.OrdinalIgnoreCase));
        }
    }


}
