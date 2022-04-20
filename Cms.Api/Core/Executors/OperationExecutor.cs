using Cms.Api.Abstractions;

namespace Cms.Api.Core.Executors
{
    public class OperationExecutor<TOperationRequest, TResult> : IOperationExecutor<TOperationRequest, TResult> where TOperationRequest : IOperationRequest<TResult>
    {
        public virtual Task<TResult> ExecuteAsync<TExecutor>(TOperationRequest request, Func<TExecutor, bool> prediate) where TExecutor : IOperation<TOperationRequest, TResult>
        {
            using (var scope = ServiceCompositionRoot.BeginLifetimeScope())
            {
                var executors = scope.ServiceProvider.GetServices<TExecutor>();
                var exec = executors.FirstOrDefault(prediate) ?? default;
                if (exec == null)
                    throw new InvalidOperationException("Invalid request");
                return exec.ExecuteAsync(request);
            }
        }
    }
}
