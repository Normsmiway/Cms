using Cms.Api.Core;
using Cms.Api.Core.Completion;
using Cms.Api.Core.Initiation;
using Microsoft.AspNetCore.Mvc;

namespace Cms.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConsentsController : ControllerBase
    {
        private readonly IConsentService _service;

        public ConsentsController(IConsentService service)
        {
            _service = service;
        }

        [HttpPost(Name = "initiate")]
        public async Task<IActionResult> InitiateAsync(ConsentInitiationRequest request)
        {
            return Ok(await _service.InitiateAsync(request));
        }

        [HttpPost(Name = "complete")]
        public async Task<IActionResult> CompleteAsync( ConsentCompletionRequest request)
        {
            return Ok(await _service.CompleteAsync(request));

        }
    }
}