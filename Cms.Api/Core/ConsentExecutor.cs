namespace Cms.Api.Core
{
    public class ConsentExecutor
    {
        public void InitiateAsync()
        {

        }
        public static Task<ConsentResult> ConsentAsync(ConsentRequest request, CancellationToken cancellationToken = default)
        {
            return ConsentAsync(request, cancellationToken);
           // return ConsentOperationAccessor.ConsentAsync(request);
        }
        public void CompleteAsync()
        {

        }
    }
}
