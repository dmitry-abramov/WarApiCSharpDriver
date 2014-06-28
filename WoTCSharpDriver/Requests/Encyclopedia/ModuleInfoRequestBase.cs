using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WoTCSharpDriver.Attributes;

namespace WoTCSharpDriver.Requests.Encyclopedia
{
    public class ModuleInfoRequestBase : EncyclopediaRequestBase
    {
        [RequestParameter("module_id", false)]
        public string ModuleId { get; set; }

        // todo: create consts
        [RequestParameter("nation", false)]
        public Nation Nation { get; set; }
    }
}
