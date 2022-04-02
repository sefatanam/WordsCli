using System.Text.Json.Serialization;

namespace WordsCli;

public class Query
{
    [JsonPropertyName("word")] public string? Word { get; set; }
    [JsonPropertyName("origin")] public string? Origin { get; set; }
    [JsonPropertyName("meanings")] public List<Meaning>? Meanings { get; set; }
}

public class Meaning
{
    [JsonPropertyName("partOfSpeech")] public string? PartOfSpeech { get; set; }
    [JsonPropertyName("definitions")] public List<Definition>? Definitions { get; set; }
    [JsonPropertyName("synonyms")] public List<string>? Synonyms { get; set; }
}

public class Definition
{
    [JsonPropertyName("definition")] public string? Name { get; set; }
    [JsonPropertyName("example")] public string? Example { get; set; }
    [JsonPropertyName("synonyms")] public List<string>? Synonyms { get; set; }
    [JsonPropertyName("antonyms")] public List<string>? Antonyms { get; set; }
}
//
// public partial class WordContracts
// {
//     [JsonPropertyName("word")] public string WordWord { get; set; }
//
//     [JsonPropertyName("phonetics")] public List<Phonetic> Phonetics { get; set; }
//
//     [JsonPropertyName("meanings")] public List<Meaning> Meanings { get; set; }
// }
//
// public partial class Meaning
// {
//     [JsonPropertyName("partOfSpeech")] public string PartOfSpeech { get; set; }
//
//     [JsonPropertyName("definitions")] public List<Definition> Definitions { get; set; }
// }
//
// public partial class Definition
// {
//     [JsonPropertyName("definition")] public string DefinitionDefinition { get; set; }
//
//     [JsonPropertyName("example")] public string Example { get; set; }
//
//     [JsonPropertyName("synonyms")] public List<string> Synonyms { get; set; }
// }
//
// public partial class Phonetic
// {
//     [JsonPropertyName("text")] public string Text { get; set; }
//
//     [JsonPropertyName("audio")] public Uri Audio { get; set; }
// }

// public partial class Word
// {
//     public static List<Word> FromJson(string json) => JsonConvert.DeserializeObject<List<Word>>(json, WordContracts.Converter.Settings);
// }