using System.Collections.Generic;

namespace WarApi.CodeGenerator.Models.Api
{
    public class Request
    {
        public string Name { get; set; }

        public string Block { get; set; }

        public string Description { get; set; }

        public IEnumerable<RequestParameter> Parameters { get; set; }
    }
}