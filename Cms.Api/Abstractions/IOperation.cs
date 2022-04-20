using Cms.Api.Core;

namespace Cms.Api.Abstractions
{
    public interface IOperation<TOperationRequest, TResult> where TOperationRequest : IOperationRequest<TResult>
    {
        public Task<TResult> ExecuteAsync(TOperationRequest request);
    }

   
}
