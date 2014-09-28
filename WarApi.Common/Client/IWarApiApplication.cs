using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarApi.Requests;

namespace WarApi.Client
{
    public interface IWarApiApplication
    {
        string ApplicationId { get; }

        TRequest CreateRequest<TRequest>() where TRequest : RequestBase, new();

        string GetResponseAsStringFor(RequestBase request);

        TResponse GetResponseFor<TResponse>(RequestBase request);
    }
}
