
using WordsCli;
using static System.Console;


Start:
Write("Enter your word: ");
var query = ReadLine()?.Trim();

if (query is null)
{
    goto Start;
}

var engine = new Core();
var result = await engine.Search(query);

Core.Print(result);
