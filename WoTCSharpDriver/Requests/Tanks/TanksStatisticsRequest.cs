using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoTCSharpDriver.Requests.Tanks
{
    public class TanksStatisticsRequest : TanksRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "stats";
            }
        }
    }
}
