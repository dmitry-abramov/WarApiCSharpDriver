using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;

namespace WarApiCSharpDriver.Responses
{
    [DataContract]
    public class ResponseBase<TData>
    {
        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "error")]
        public Error Error { get; set; }

        [DataMember(Name = "count")]
        public int Count { get; set; }

        [DataMember(Name = "data")]
        public TData Data { get; set; }
    }
}
