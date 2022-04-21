using Cms.Api.Core.Initiation;

namespace Cms.Api.UseCases.Balances
{
    public class BalanceEnquiryConsentRequest : ConsentInitiationRequest
    {
        public override string RequestType => "Balance";
    }
}
