using Cms.Api.Abstractions;
using Cms.Api.Core.Executors;

namespace Cms.Api.Core.Completion
{
    public class ConsentCompleter: OperatorBase<ConsentCompletionRequest, ConsentCompletionResult>
    {
        public ConsentCompleter(IOperationExecutor<ConsentCompletionRequest, ConsentCompletionResult> exec) : base(exec)
        {
        }

        public Task<ConsentCompletionResult> CompleteAsync(ConsentCompletionRequest request)
        {
            return _exec.ExecuteAsync<IConsentCompletionOperation>(request, i
                => string.Equals(i.OperationType, request.RequestType, StringComparison.OrdinalIgnoreCase));
        }
    }


}
