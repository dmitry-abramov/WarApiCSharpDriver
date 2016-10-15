using System;
using System.Net;
using WarApi.CodeGenerator.Contracts;

namespace WarApi.CodeGenerator
{
    public class PageDownloader : IPageDownloader
    {
        public string Download(Uri url)
        {
            using (var client = new WebClient())
            {
                client.Headers.Add("X-Requested-With: XMLHttpRequest");
                return client.DownloadString(url);
            }            
        }
    }
}
