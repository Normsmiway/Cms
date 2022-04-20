using Cms.Api.Abstractions;
using Cms.Api.Core.Executors;

namespace Cms.Api.Core.Initiation
{
    public class ConsentInitiator : OperatorBase<ConsentInitiationRequest, ConsentInitiationResult>
    {
        public ConsentInitiator(IOperationExecutor<ConsentInitiationRequest, ConsentInitiationResult> exec) : base(exec)
        {
        }

        public Task<ConsentInitiationResult> InitiateAsync(ConsentInitiationRequest request)
        {
            return _exec.ExecuteAsync<IConsentInitiationOperation>(request, i
                => string.Equals(i.OperationType, request.RequestType, StringComparison.OrdinalIgnoreCase));
        }
    }
}
