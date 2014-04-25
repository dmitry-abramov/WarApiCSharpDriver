using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoTCSharpDriver
{
    public class WoTApplication
    {
        public string ApplicationId { get; private set; }

        public WoTApplication(string applicationId)
        {
            ApplicationId = applicationId;
        }

        public RequestBase CreateRequest<TRequest>() where TRequest : RequestBase, new()
        {
            var request = new TRequest();
            request.ApplicationId = ApplicationId;
            return request;
        }
    }
}
