using WarApi.Utilities;
using WarApi.Utilities.Attributes;
using WarApi.ConstantVlaues;

namespace WarApi.Requests.Encyclopedia
{
    public class ModuleInfoRequestBase : EncyclopediaRequestBase
    {
        [RequestParameter("module_id", false)]
        public ListOrSingleValue<string> ModuleId { get; set; }

        [RequestParameter("nation", false)]
        public Nation Nation { get; set; }
    }
}
