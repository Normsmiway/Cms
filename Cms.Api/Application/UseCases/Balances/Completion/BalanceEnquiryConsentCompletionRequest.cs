using Cms.Api.Core.Completion;

namespace Cms.Api.UseCases.Balances.Completion
{
    public class BalanceEnquiryConsentCompletionRequest : ConsentCompletionRequest
    {
        public override string RequestType => "Balance";
    }
}
