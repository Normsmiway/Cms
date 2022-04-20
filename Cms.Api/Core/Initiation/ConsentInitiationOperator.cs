using Cms.Api.Abstractions;
using Cms.Api.Core.Executors;

namespace Cms.Api.Core.Initiation
{
    public class ConsentInitiationOperator : OperatorBase<ConsentInitiationRequest, ConsentInitiationResult>
    {
        public ConsentInitiationOperator(IOperationExecutor<ConsentInitiationRequest, ConsentInitiationResult> exec) : base(exec)
        {
        }

        public Task<ConsentInitiationResult> InitiateAsync(ConsentInitiationRequest request)
        {
            return _exec.ExecuteAsync<IConsentInitiationOperation>(request, i
                => string.Equals(i.OperationType, request.RequestType, StringComparison.OrdinalIgnoreCase));
        }
    }
}
