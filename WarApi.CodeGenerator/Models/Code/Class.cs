using System.Collections.Generic;

namespace WarApi.CodeGenerator.Models.Code
{
    internal class Class
    {
        public Class()
        {
            Properties = new List<Property>();
        }

        public string Name { get; set; }

        public string Namespace { get; set; }

        public string Summary { get; set; }

        public IEnumerable<Property> Properties { get; set; }
    }
}
