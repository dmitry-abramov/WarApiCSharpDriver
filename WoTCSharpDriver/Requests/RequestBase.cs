using System;
using System.Collections.Generic;
using System.Linq;

using WarApi.Utilities.Extensions;
using WarApi.Utilities.Attributes;
using System.Web;
using WarApi.ConstantValues;

namespace WarApi.Requests
{
    public class RequestBase
    {
        private IDictionary<string, string> parameters;

        public virtual string MethodBlock
        {
            get
            {
                return "MethodBlock";
            }
        }

        public virtual string MethodName
        {
            get
            {
                return "MethodName";
            }
        }

        [RequestParameter("access_token", false)]
        public string AccessToken { get; set; }

        [RequestParameter("application_id", true)]
        public string ApplicationId { get; set; }

        [RequestParameter("language", false)]
        public Language Language { get; set; }

        public IDictionary<string, string> Parameters
        {
            get
            {
                return new Dictionary<string, string>(GetParameters(false));
            }
        }

        public RequestBase()
        {
            parameters = new Dictionary<string, string>();
        }

        public void AddParameter(string key, string value)
        {
            parameters.AddOrUpdate(key, value);
        }

        public string GetParameter(string key)
        {
            string value;
            if (GetParameters(false).TryGetValue(key, out value))
            {
                return HttpUtility.UrlDecode(value);
            }

            throw new ArgumentException(string.Format("Request does not have parameter '{0}'", key), "key");
        }

        public string GetPath()
        {
            return string.Format("{0}/{1}", MethodBlock, MethodName);
        }

        public string GetParametersLikeUri()
        {
            return GetParameters(true).ToUriParametersString();
        }


        protected IDictionary<string, string> GetParameters(bool isNeedRequeredValidation)
        {
            var requestType = this.GetType();
            var requestFields = requestType.GetProperties();

            foreach (var field in requestFields)
            {
                if (Attribute.IsDefined(field, typeof(RequestParameterAttribute)))
                {
                    var attribute = Attribute.GetCustomAttribute(field, typeof(RequestParameterAttribute)) as RequestParameterAttribute;
                    var name = string.IsNullOrEmpty(attribute.Name) ? field.Name : attribute.Name;

                    var value = field.GetValue(this);

                    if (value != null)
                    {                      
                        var stringValue = value.ToString();

                        if (value is DateTime)
                        {
                            stringValue = ((DateTime)value).ToUnixTime().ToString();
                        }

                        stringValue = HttpUtility.UrlPathEncode(stringValue);

                        if (!string.IsNullOrEmpty(stringValue) || !isNeedRequeredValidation)
                        {
                            parameters.AddOrUpdate(name, stringValue);
                            continue;
                        }
                    }

                    if (!isNeedRequeredValidation)
                    {
                        parameters.AddOrUpdate(name, null);
                        continue;
                    }

                    if (attribute.IsRequired && isNeedRequeredValidation)
                    {
                        throw new InvalidOperationException(string.Format("Field '{0}' is required but it is null", field.Name));
                    }
                }
            }

            return parameters;
        }
    }
}
