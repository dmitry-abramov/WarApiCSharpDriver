using System;

namespace WoTCSharpDriver.Attributes
{
    internal class RequestParameterAttribute : Attribute
    {
        public string Name { get; set; }
        public bool IsRequired { get; set; }

        public RequestParameterAttribute()
        {
            IsRequired = false;
        }

        public RequestParameterAttribute(string name, bool isRequired = false)
        {
            Name = name;
            IsRequired = isRequired;
        }
    }
}
