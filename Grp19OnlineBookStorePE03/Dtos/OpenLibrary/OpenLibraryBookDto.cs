namespace Grp19OnlineBookStorePE03.Dtos.OpenLibrary;
using System.Text.Json.Serialization;

public class OpenLibraryBookDto
{
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("author_name")]
    public List<string>? Author_Name { get; set; }

    [JsonPropertyName("first_publish_year")]
    public int? First_Publish_Year { get; set; }

    [JsonPropertyName("isbn")]
    public List<string>? Isbn { get; set; }

    [JsonPropertyName("cover_i")]
    public int? Cover_I { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }
    public string CoverUrl => Cover_I.HasValue
    ? $"https://covers.openlibrary.org/b/id/{Cover_I}-M.jpg"
    : "https://via.placeholder.com/80x120?text=No+Cover";
}