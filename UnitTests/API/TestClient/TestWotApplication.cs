using System.Text;
using System.Net;

using System.IO;

using WarApiCSharpDriver.Requests;
using Utilities.Serialization;

namespace WarApiCSharpDriver
{
    public class TestWotApplication
    {
        private readonly string server;

        private readonly string apiName;

        private readonly ISerializer serializer;

        public string ApplicationId { get; private set; }

        public TestWotApplication(string applicationId, string server, string apiName)
        {
            ApplicationId = applicationId;
            this.server = server;
            this.apiName = apiName;

            serializer = new NewtonsoftSerializer();
        }

        public TestWotApplication(string applicationId, string server, string apiName, ISerializer serializer)
        {
            ApplicationId = applicationId;
            this.server = server;
            this.apiName = apiName;

            this.serializer = serializer;
        }

        public TRequest CreateRequest<TRequest>() where TRequest : RequestBase, new()
        {
            var request = new TRequest();
            request.ApplicationId = ApplicationId;
            return request;
        }

        public string GetResponseAsStringFor(RequestBase request)
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

        public TResponse GetResponseFor<TResponse>(RequestBase request)
        {
            var requestString = string.Format("https://{0}/{1}/{2}/?{3}",
                server,
                apiName,
                request.GetPath(),
                request.GetParametersLikeUri());

            var webClient = new WebClient();
            var responseString = webClient.DownloadString(requestString);

            var response = serializer.Deserialize<TResponse>(responseString);

            return response;
        }
    }
}

