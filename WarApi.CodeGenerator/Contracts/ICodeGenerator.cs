using WarApi.CodeGenerator.Models;
using WarApi.CodeGenerator.Models.Api;

namespace WarApi.CodeGenerator.Contracts
{
    public interface ICodeGenerator
    {
        GenerationResult Generate(Method apiMethod);
    }
}
