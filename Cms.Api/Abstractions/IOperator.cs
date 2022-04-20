namespace Cms.Api.Abstractions
{
    public interface IOperator<TOperationRequest, TResult> where TOperationRequest : IOperationRequest<TResult>
    {
    }



   
}
