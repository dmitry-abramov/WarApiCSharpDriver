using WarApi.Requests;

namespace WarApi.Client
{
    public interface IWarApiApplication
    {
        string ApplicationId { get; }

        TRequest CreateRequest<TRequest>() where TRequest : RequestBase, new();

        string GetResponseAsStringFor(RequestBase request);

        TResponse GetResponseFor<TResponse>(RequestBase request);
    }
}
