using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoTCSharpDriver.Requests.Encyclopedia
{
    public class TankTurretsRequest : ModuleInfoRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "tankturrets";
            }
        }
    }
}
