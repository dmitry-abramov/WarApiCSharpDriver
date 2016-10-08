using System.Collections.Generic;

namespace WarApi.CodeGenerator.Models.Api
{
    public class Response
    {
        public string Name { get; set; }

        public string Block { get; set; }

        public IEnumerable<ResponseParameter> Parameters { get; set; }
    }
}