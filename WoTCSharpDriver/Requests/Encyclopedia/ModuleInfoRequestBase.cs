using Utilities.Attributes;

namespace WarApiCSharpDriver.Requests.Encyclopedia
{
    public class ModuleInfoRequestBase : EncyclopediaRequestBase
    {
        [RequestParameter("module_id", false)]
        public string ModuleId { get; set; }

        [RequestParameter("nation", false)]
        public Nation Nation { get; set; }
    }
}
