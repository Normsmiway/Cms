using Cms.Api.Core.Completion;

namespace Cms.Api.UseCases.Balances.Completion
{
    public sealed class BalanceConsentCompletionOperation : ConsentCompletionOperation
    {
        public override string OperationType => new BalanceEnquiryConsentCompletionRequest().RequestType;
        protected override Task<ConsentCompletionResult> CompleteAsync(ConsentCompletionRequest request)
        {
            //Actual implementation
            throw new NotImplementedException();
        }
    }
}
