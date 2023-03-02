// See https://aka.ms/new-console-template for more information

using System.Text;
using Antlr4.StringTemplate;
using TryCustomListenerForAntlr4;

Console.WriteLine("Hello, World!");


var cwd = Directory.GetCurrentDirectory();
var templateDirectory = new TemplateGroupDirectory($"{cwd}/Templates", '$', '$');
var mainTemplate = templateDirectory.GetInstanceOf("main");

mainTemplate.Add("content", null);

var ms = new MemoryStream();
using (var writer = new StreamWriter(ms, Encoding.UTF8))
{
    mainTemplate.Write(new AutoIndentWriter(writer), new NLogErrorListener());
    writer.Flush();
    ms.Seek(0, SeekOrigin.Begin);
    Console.WriteLine(await new StreamReader(ms).ReadToEndAsync());
}