using System;
using WarApi.CodeGenerator.Models.Api;

namespace WarApi.CodeGenerator.Contracts
{
    public interface IPageParser
    {
        Method Parse(Uri url);
    }
}
