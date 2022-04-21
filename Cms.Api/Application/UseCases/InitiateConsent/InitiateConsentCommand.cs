using Cms.Api.Core;
using Cms.Api.UseCases.Balances;
using MediatR;

namespace Cms.Api.Application.UseCases.InitiateConsent
{
    public record InitiateConsentCommand(string RequestType) : IRequest<string>
    {
    }

    internal sealed class InitiateConsentCommandHandler : IRequestHandler<InitiateConsentCommand, string>
    {
        private readonly IConsentService _service;

        public InitiateConsentCommandHandler(IConsentService service)
        {
            _service = service;
        }


        public async Task<string> Handle(InitiateConsentCommand command, CancellationToken cancellationToken)
        {
            var request = new BalanceEnquiryConsentRequest();

            var result = await _service.InitiateAsync(request);

            return result.ToString();
        }
    }
}
