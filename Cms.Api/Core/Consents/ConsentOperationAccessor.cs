using Cms.Api.Abstractions;
using Cms.Api.Core.Executors;

namespace Cms.Api.Core
{
    public sealed class ConsentOperationAccessor : OperatorBase<ConsentRequest, ConsentResult>
    {
        public ConsentOperationAccessor(IOperationExecutor<ConsentRequest, ConsentResult> exec) : base(exec)
        {
        }

        public Task<ConsentResult> ConsentAsync(ConsentRequest request)
        {
            return _exec.ExecuteAsync<IConsentOperation>(request, c => string.Equals(c.DeliveryMechanism.ToString(),
                      request.DeliveryMechanism.ToString(), StringComparison.OrdinalIgnoreCase));
            #region
            //{
            //    var consentOperators = scope.ServiceProvider.GetServices<IConsentOperation>();
            //    var operation = consentOperators?.FirstOrDefault(c => string.Equals(c.DeliveryMechanism.ToString(),
            //         request.DeliveryMechanism.ToString(), StringComparison.OrdinalIgnoreCase));
            //    if (operation == null)
            //        throw new InvalidOperationException("Invalid consent request");

            //    return operation.ExecuteAsync(request);
            //}
            #endregion
        }
    }
}
