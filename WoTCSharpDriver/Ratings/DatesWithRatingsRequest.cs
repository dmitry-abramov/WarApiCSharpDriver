using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WoTCSharpDriver.Attributes;

namespace WoTCSharpDriver.Ratings
{
    public class DatesWithRatingsRequest : RatingsRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "dates";
            }
        }

        // todo: create constants for it
        [RequestParameter("type", true)]
        public string Type { get; set; }
    }
}
