namespace Cms.Api.Abstractions
{
    public interface IOperationExecutor<TOperationRequest, TResult> where TOperationRequest : IOperationRequest<TResult>
    {
        public Task<TResult> ExecuteAsync<TExecutor>(TOperationRequest request, Func<TExecutor, bool> prediate) where TExecutor : IOperation<TOperationRequest, TResult>;
    }

}
