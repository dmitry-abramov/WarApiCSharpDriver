using WarApi.Requests;
using WarApi.Utilities.Attributes;

namespace WarApi.Requests.Ratings
{
    public class RatingsRequestBase : RequestBase
    {
        public override string MethodBlock
        {
            get
            {
                return "ratings";
            }
        }

        [RequestParameter("fields", false)]
        public string Fields { get; set; }
    }
}
