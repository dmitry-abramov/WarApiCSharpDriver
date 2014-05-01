using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoTCSharpDriver.Ratings
{
    public class RatingsTypesRequest : RatingsRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "types";
            }
        }
    }
}
