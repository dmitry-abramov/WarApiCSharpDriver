using System.Text;
using System.Net;

using System.IO;
using System.Runtime.Serialization.Json;

using WoTCSharpDriver.Requests;

namespace WoTCSharpDriver
{
    public class WoTApplication
    {
        private readonly string server;

        private readonly string apiName;

        public string ApplicationId { get; private set; }

        public WoTApplication(string applicationId, string server, string apiName)
        {
            ApplicationId = applicationId;
            this.server = server;
            this.apiName = apiName;
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

            var serializer = new DataContractJsonSerializer(typeof(TResponse));
            
            var stream = new MemoryStream(Encoding.Default.GetBytes(responseString));
            var response = (TResponse)serializer.ReadObject(stream);

            return response;
        }
    }
}

