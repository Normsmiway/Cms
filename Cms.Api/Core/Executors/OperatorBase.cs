using Cms.Api.Abstractions;

namespace Cms.Api.Core.Executors
{
    public abstract class OperatorBase<TOperationRequest, TResult> : IOperator<TOperationRequest, TResult> where TOperationRequest : IOperationRequest<TResult>
    {
        protected readonly IOperationExecutor<TOperationRequest, TResult> _exec;

        protected OperatorBase(IOperationExecutor<TOperationRequest, TResult> exec)
        {
            _exec = exec;
        }
    }
}
