using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoTCSharpDriver.Attributes
{
    internal class RequestParameterAttribute : Attribute
    {
        public string Name { get; set; }
        public bool IsRequired { get; set; }

        public RequestParameterAttribute()
        { 
        }

        public RequestParameterAttribute(string name, bool isRequired)
        {
            Name = name;
            IsRequired = isRequired;
        }
    }
}
