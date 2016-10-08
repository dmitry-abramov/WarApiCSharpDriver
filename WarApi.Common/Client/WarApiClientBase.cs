using System.Net;

using WarApi.Requests;
using WarApi.Utilities.Serialization;

namespace WarApi.Client
{
    public class WarApiClientBase : IWarApiApplication
    {
        protected readonly string server;

        protected readonly string apiName;

        protected readonly ISerializer serializer;

        public string ApplicationId { get; protected set; }

        protected WarApiClientBase(string applicationId, string server, string apiName, ISerializer serializer)
        {
            ApplicationId = applicationId;
            this.server = server;
            this.apiName = apiName;

            this.serializer = serializer;
        }

        public virtual TRequest CreateRequest<TRequest>() where TRequest : RequestBase, new()
        {
            var request = new TRequest();
            request.ApplicationId = ApplicationId;
            return request;
        }

        public virtual string GetResponseAsStringFor(RequestBase request)
        {
            var requestString = string.Format("https://{0}/{1}/{2}/?{3}",
                server,
                apiName,
                request.GetPath(),
                request.GetParametersLikeUri());

            var webClient = new WebClient();
            var response = webClient.DownloadString(requestString);

            return response;
        }

        public virtual TResponse GetResponseFor<TResponse>(RequestBase request)
        {
            var responseString = GetResponseAsStringFor(request);

            var response = serializer.Deserialize<TResponse>(responseString);

            return response;
        }
    }
}

