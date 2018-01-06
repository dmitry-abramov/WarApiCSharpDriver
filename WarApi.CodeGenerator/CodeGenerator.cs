using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarApi.CodeGenerator.Contracts;
using WarApi.CodeGenerator.Models;
using WarApi.CodeGenerator.Models.Api;
using WarApi.CodeGenerator.Models.Code;

namespace WarApi.CodeGenerator
{
    public class CodeGenerator : ICodeGenerator
    {
        public GenerationResult Generate(Method apiMethod)
        {
            var requestClass = GenerateRequestClass(apiMethod);
            var requestCode = GenerateCode(requestClass);

            var responseClass = GenerateResponseClass(apiMethod);
            var responseCode = GenerateCode(responseClass);

            return new GenerationResult
            {
                RequestClass = requestCode,
                ResponseClass = responseCode
            };
        }

        private Class GenerateResponseClass(Method method)
        {
            var responseClass = new Class();

            responseClass.Name = $"{method.Name}Response";
            responseClass.Namespace = $"WarApi.Response.{method.Block}";
            responseClass.Summary = method.Description;

            var properties = new List<Property>();
            foreach (var parameter in method.ResponseParameters)
            {
                var property = new Property();
                property.Name = string.Join("_", parameter.Name);
                property.Type = MapResponseParameterType(parameter.Type);
                property.Summary = parameter.Description;

                var attributes = new List<PropertyAttribute>
                {
                    new PropertyAttribute
                    {
                        Name = nameof(JsonProperty),
                        ConstructorParameters = new []
                        {
                            string.Join("_", parameter.Name)
                        }
                    }
                };

                properties.Add(property);
            }
            responseClass.Properties = properties;

            return responseClass;
        }

        private Class GenerateRequestClass(Method method)
        {
            var requestClass = new Class();

            requestClass.Name = $"{method.Name}Request";
            requestClass.Namespace = $"WarApi.Requests.{method.Block}";
            requestClass.Summary = method.Description;

            var properties = new List<Property>();
            foreach (var parameter in method.RequestParameters)
            {
                var property = new Property();
                property.Name = parameter.Name;
                property.Type = MapRequestParameterType(parameter.Type);
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
            return requestClass;
        }

        private string GenerateCode(Class classModel)
        {
            var code = new StringBuilder();
            code.AppendLine($"namespace {classModel.Namespace}");
            code.AppendLine($"{{");
            code.AppendLine($"  public class {classModel.Name}");
            code.AppendLine($"  {{");
            foreach (var property in classModel.Properties)
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

        private static Type MapRequestParameterType(string type)
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

        private static Type MapResponseParameterType(string type)
        {
            switch (type)
            {
                case "string":
                    return typeof(string);
                case "numeric":
                    return typeof(int);
                case "float":
                    return typeof(int);
                default:
                    return typeof(object);
            }
        }
    }
}
