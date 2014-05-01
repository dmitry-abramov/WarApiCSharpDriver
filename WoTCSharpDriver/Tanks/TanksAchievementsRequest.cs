using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoTCSharpDriver.Tanks
{
    public class TanksAchievementsRequest : TanksRequestBase
    {
        public override string MethodName
        {
            get
            {
                return "achievements";
            }
        }
    }
}
