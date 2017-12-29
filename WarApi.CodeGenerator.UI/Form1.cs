using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarApi.CodeGenerator.Contracts;

namespace WarApi.CodeGenerator.UI
{
    public partial class MainForm : Form
    {
        private readonly IPageParser pageParser;
        private readonly ICodeGenerator codeGenerator;

        public MainForm()
        {
            InitializeComponent();

            pageParser = new PageParser(new PageDownloader());
            codeGenerator = new CodeGenerator();
        }

        private void ParseButtonClick(object sender, EventArgs e)
        {
            var url = new Uri(UrlTextBox.Text);
            var method = pageParser.Parse(url);

            var methodAsString = new StringBuilder();
            methodAsString.AppendLine($"Block: {method.Block}");
            methodAsString.AppendLine($"Name: {method.Name}");
            methodAsString.AppendLine($"Description: {method.Description}");

            methodAsString.AppendLine(string.Empty);

            methodAsString.AppendLine($"Request parameters");
            foreach (var parameter in method.RequestParameters)
            {
                methodAsString.AppendLine($"    Name: {parameter.Name}");
                methodAsString.AppendLine($"    Type: {parameter.Type}");
                methodAsString.AppendLine($"    Required: {parameter.IsRequired}");
                methodAsString.AppendLine($"    Description: {parameter.Description}");
                methodAsString.AppendLine(string.Empty);
            }

            methodAsString.AppendLine($"Response info");
            foreach (var parameter in method.ResponseParameters)
            {
                methodAsString.AppendLine($"    Name: {string.Join(".", parameter.Name)}");
                methodAsString.AppendLine($"    Type: {parameter.Type}");
                methodAsString.AppendLine($"    Description: {parameter.Description}");
                methodAsString.AppendLine(string.Empty);
            }

            ParsedMethodRichTextBox.Text = methodAsString.ToString();

            var generatedCode = codeGenerator.Generate(method);
            GeneratedCodeRichTextBox.Text = generatedCode;
        }
    }
}
