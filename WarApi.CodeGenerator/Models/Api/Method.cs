using System.Collections.Generic;

namespace WarApi.CodeGenerator.Models.Api
{
    public class Method
    {
        public Method()
        {
            ResponseParameters = new List<ResponseParameter>();
            RequestParameters = new List<RequestParameter>();
        }

        public string Name { get; set; }

        public string Block { get; set; }

        public string Description { get; set; }

        public IEnumerable<ResponseParameter> ResponseParameters { get; set; }

        public IEnumerable<RequestParameter> RequestParameters { get; set; }
    }
}
