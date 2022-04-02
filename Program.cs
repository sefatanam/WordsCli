//
// using WordsCli;
// using static System.Console;
//
//
// Start:
// Write("Enter your word: ");
// var query = ReadLine()?.Trim();
//
// if (query is null)
// {
//     goto Start;
// }
//
// var engine = new Core();
// var result = await engine.Search(query);
//
// Core.Print(result);


using Cocona;
using Microsoft.Extensions.DependencyInjection;
using WordsCli;
using static System.Console;

var builder = CoconaApp.CreateBuilder();
// builder.Services.AddSingleton<Core>();
var app = builder.Build();


app.AddCommand("sym", async (string w) =>
{
    var engine = new Core();
    var result = await engine.Search(w);
    engine.Print(result);
});

app.Run();