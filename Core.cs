using System.Net;
using System.Net.Http.Json;
using ConsoleTables;
using static System.Console;

namespace WordsCli;

public class Core
{
    public async Task<Query?> Search(string word)
    {
        try
        {
            WriteLine("Please wait...");
            var httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://api.dictionaryapi.dev/api/v2/entries/en/")
            };


            var response = await httpClient.GetAsync(word);

            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                return null;
            }

            var convertResponseToModel = await response.Content.ReadFromJsonAsync<Query[]>();
            return convertResponseToModel?.FirstOrDefault();
        }
        catch (Exception e)
        {
            WriteLine(e.Message);
            return null;
        }
    }


    public static void Print(Query? query)
    {
        Clear();
        // var introTable = new ConsoleTable(nameof(query.Word), nameof(query.Origin));
        // introTable.AddRow(query?.Word, query?.Origin);
        // introTable.Write();
        WriteLine($"Synonyms of '{query?.Word}' are bellow : \n");
        var synonymsTable = new ConsoleTable("COLUMN 1", " COLUMN 2", "COLUMN 3");
        var enumerable = query?.Meanings?.First()?.Definitions?.First()?.Synonyms;


        for (var i = 0; i < enumerable?.Count; i += 3)
        {
            try
            {
                synonymsTable.AddRow(enumerable[i], enumerable[i + 1], enumerable[i + 2]);
            }
            catch (Exception)
            {
                goto end;
            }
        }

        end:
        synonymsTable.Write();

        WriteLine("\n \n");
    }
}