using System.Collections.Generic;

namespace WarApi.CodeGenerator.Models.Code
{
    public class PropertyAttribute
    {
        public string Name { get; set; }

        public IEnumerable<string> ConstructorParameters { get; set; }
    }
}