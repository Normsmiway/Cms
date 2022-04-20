namespace Cms.Api.Core
{
    public sealed class ConsentOperationAccessor
    {
        public static Task<ConsentResult> ConsentAsync(ConsentRequest request)
        {
            using (var scope = ServiceCompositionRoot.BeginLifetimeScope())
            {
                var consentOperators = scope.ServiceProvider.GetServices<IConsentOperation>();
                var operation = consentOperators?.FirstOrDefault(c => string.Equals(c.DeliveryMechanism.ToString(),
                     request.DeliveryMechanism.ToString(), StringComparison.OrdinalIgnoreCase));
                if (operation == null)
                    throw new InvalidOperationException("Invalid consent request");

                return operation.ExecuteAsync(request);
            }
        }
    }
}
