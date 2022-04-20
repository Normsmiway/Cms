using Cms.Api.Core.Initiation;

namespace Cms.Api.UseCases.Balances
{
    public sealed class BalanceConsentInitiationOperation : ConsentInitiationOperation
    {
        public override string OperationType { get; } = new BalanceEnquiryConsentRequest().RequestType;
        protected override Task<ConsentInitiationResult> InitiateAsync(ConsentInitiationRequest request)
        {
            //write your implementation here
            throw new NotImplementedException();
        }
    }
}
