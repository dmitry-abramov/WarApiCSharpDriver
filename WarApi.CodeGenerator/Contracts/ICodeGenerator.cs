using WarApi.CodeGenerator.Models.Api;

namespace WarApi.CodeGenerator.Contracts
{
    public interface ICodeGenerator
    {
        string Generate(Method apiMethod);
    }
}
