namespace Grp19OnlineBookStorePE03.Dtos.OpenLibrary;
using System.Text.Json.Serialization;

public class OpenLibrarySearchResult
{
    [JsonPropertyName("docs")]
    public List<OpenLibraryBookDto> Docs { get; set; } = new();
}