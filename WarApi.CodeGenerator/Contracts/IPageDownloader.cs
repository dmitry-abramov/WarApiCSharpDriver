using System;

namespace WarApi.CodeGenerator.Contracts
{
    public interface IPageDownloader
    {
        string Download(Uri url);
    }
}
