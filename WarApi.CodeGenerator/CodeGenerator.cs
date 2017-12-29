using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarApi.CodeGenerator.Contracts;
using WarApi.CodeGenerator.Models.Api;
using WarApi.CodeGenerator.Models.Code;

namespace WarApi.CodeGenerator
{
    public class CodeGenerator : ICodeGenerator
    {
        public string Generate(Method apiMethod)
        {
            var requestClass = new Class();

            requestClass.Name = $"{apiMethod.Name}Request";
            requestClass.Namespace = $"WarApi.Requests.{apiMethod.Block}";
            requestClass.Summary = apiMethod.Description;

            var properties = new List<Property>();
            foreach (var parameter in apiMethod.RequestParameters)
            {
                var property = new Property();
                property.Name = parameter.Name;
                property.Type = MapType(parameter.Type);
                property.Summary = parameter.Description;

                var attributes = new List<PropertyAttribute>
                {
                    new PropertyAttribute
                    {
                        Name = nameof(RequestParameter),
                        ConstructorParameters = new []
                        {
                            parameter.Name
                        }
                    }
                };

                properties.Add(property);
            }
            requestClass.Properties = properties;

            var code = new StringBuilder();
            code.AppendLine($"namespace {requestClass.Namespace}");
            code.AppendLine($"{{");
            code.AppendLine($"  public class {requestClass.Name}");
            code.AppendLine($"  {{");
            foreach (var property in requestClass.Properties)
            {
                foreach (var attribute in property.Attributes)
                {
                    code.AppendLine($"      [{attribute.Name}({string.Join(", ", attribute.ConstructorParameters)})]");
                }
                
                code.AppendLine($"      public {property.Type.Name} {property.Name} {{ get; set; }}");
                code.AppendLine(string.Empty);
            }
            code.AppendLine($"  }}");
            code.AppendLine($"}}");

            return code.ToString();
        }

        private static Type MapType(string type)
        {
            switch (type)
            {
                case "string":
                    return typeof(string);
                case "int":
                    return typeof(int);
                default:
                    return typeof(object);
            }
        }
    }
}
