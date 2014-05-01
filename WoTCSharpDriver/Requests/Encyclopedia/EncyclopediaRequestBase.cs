using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WoTCSharpDriver.Attributes;

namespace WoTCSharpDriver.Requests.Encyclopedia
{
    public class EncyclopediaRequestBase : RequestBase
    {
        public override string MethodBlock
        {
            get
            {
                return "encyclopedia";
            }
        }

        [RequestParameter("fields", false)]
        public string Fields { get; set; }
    }
}
