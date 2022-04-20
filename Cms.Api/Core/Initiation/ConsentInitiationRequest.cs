using Cms.Api.Abstractions;

namespace Cms.Api.Core.Initiation
{
    public abstract class ConsentInitiationRequest : IOperationRequest<ConsentInitiationResult>
    {
        public abstract string RequestType { get; }
    }
}
