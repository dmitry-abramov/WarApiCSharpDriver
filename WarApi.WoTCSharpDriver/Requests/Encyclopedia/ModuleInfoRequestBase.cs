using WarApi.Utilities;
using WarApi.Utilities.Attributes;
using WarApi.ConstantValues;

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
