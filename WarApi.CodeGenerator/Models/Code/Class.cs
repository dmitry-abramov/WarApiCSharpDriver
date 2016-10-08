using System.Collections.Generic;

namespace WarApi.CodeGenerator.Models.Code
{
    class Class
    {
        public string Name { get; set; }

        public string Namespace { get; set; }

        public string Summary { get; set; }

        public IEnumerable<Property> Properties { get; set; }
    }
}
