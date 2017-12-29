using System;
using System.Collections.Generic;

namespace WarApi.CodeGenerator.Models.Code
{
    internal class Property
    {
        public Property()
        {
            Attributes = new List<PropertyAttribute>();
        }

        public string Name { get; set; }

        public Type Type { get; set; }

        public string Summary { get; set; }

        public IEnumerable<PropertyAttribute> Attributes { get; set; }
    }
}