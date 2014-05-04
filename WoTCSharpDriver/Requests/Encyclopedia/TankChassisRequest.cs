using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoTCSharpDriver.Requests.Encyclopedia
{
    public class TankChassisRequest : ModuleInfoRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "tankchassis";
            }
        }
    }
}
