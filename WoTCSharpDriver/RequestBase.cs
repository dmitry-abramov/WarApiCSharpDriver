using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoTCSharpDriver.Extensions;

namespace WoTCSharpDriver
{
    public class RequestBase
    {
        private IDictionary<string, string> parameters;

        public string MethodBlock
        {
            get
            {
                return "MethodBlock";
            }
        }

        public string MethodName
        {
            get 
            {
                return "MethodName";
            }
        }

        public string AccessToken 
        { 
            get
            {
                string accessToken;
                return parameters.TryGetValue("accessToken", out accessToken) ? accessToken : string.Empty;
            }
            set
            {
                parameters.AddOrUpdate("accessToken", value);
            }
        }
        
        public string ApplicationId 
        {
            get
            {
                string applicationId;
                return parameters.TryGetValue("applicationId", out applicationId) ? applicationId : string.Empty;
            }
            set
            {
                parameters.AddOrUpdate("applicationId", value);
            }
        }

        public IDictionary<string, string> Parameters
        {
            get 
            {                
                return new Dictionary<string, string>(parameters);
            }
        }

        public RequestBase()
        {
            parameters = new Dictionary<string, string>();
            parameters.Add("accessToken", string.Empty);
            parameters.Add("applicationId", string.Empty);
        }

        public string GetPath()
        {
            return string.Format("{0}/{1}", MethodBlock, MethodName);
        }

        public string GetParameters()
        {
            return parameters.GetLikeUriParameters();
        }
    }
}
