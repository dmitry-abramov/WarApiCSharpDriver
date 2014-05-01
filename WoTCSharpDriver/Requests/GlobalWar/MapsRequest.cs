using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoTCSharpDriver.Requests.GlobalWar
{
    public class MapsRequest : GlobalWarRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "maps";
            }
        }
    }
}
