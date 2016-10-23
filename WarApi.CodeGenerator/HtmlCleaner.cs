using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace WarApi.CodeGenerator
{
    public static class HtmlCleaner
    {
        private static Regex duplicatedWhiteSpaces = new Regex(@"[ \f\t\v]{2,}", RegexOptions.Compiled);
        private static Regex duplicatedNewLines = new Regex(@"(\r\n){2,}", RegexOptions.Compiled);

        private static IEnumerable<string> list = new List<string> { "li", "p"};

        public static string Clean(string html)
        {
            var document = new HtmlDocument();
            document.LoadHtml(html);

            var cleanedText = new StringBuilder();
            var stack = new Stack<HtmlNode>();
            stack.Push(document.DocumentNode);


            while (stack.Any())
            {
                var currentNode = stack.Pop();
                if (currentNode.HasChildNodes)
                {
                    var reversedChild = currentNode.ChildNodes.Reverse();
                    foreach (var child in reversedChild)
                    {
                        if (list.Contains(currentNode.Name))
                        {
                            stack.Push(HtmlNode.CreateNode(Environment.NewLine));
                            stack.Push(child);
                            stack.Push(HtmlNode.CreateNode(Environment.NewLine));
                        }
                        else
                        {
                            stack.Push(child);
                        }
                    }                    
                }
                else
                {
                    cleanedText.Append(currentNode.InnerText);
                }
            }

            var cleanedTextString = duplicatedWhiteSpaces.Replace(cleanedText.ToString(), " ");
            cleanedTextString = duplicatedNewLines.Replace(cleanedTextString, Environment.NewLine);
            return cleanedTextString.Trim();
        }
    }
}
