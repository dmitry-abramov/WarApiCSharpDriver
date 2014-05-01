using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WoTCSharpDriver.Requests;
using WoTCSharpDriver.Attributes;

namespace WoTCSharpDriver.Ratings
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
