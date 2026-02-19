namespace Grp19OnlineBookStorePE03.Services;
using System.Net.Http.Json;
using Grp19OnlineBookStorePE03.Dtos.OpenLibrary;
public class OpenLibraryService
{
    private readonly HttpClient _http;

    public OpenLibraryService(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<OpenLibraryBookDto>> SearchBooksAsync(string query, string searchType = "title", int limit = 20)
    {
        if (string.IsNullOrWhiteSpace(query))
            return new();

        string url = searchType switch
        {
            "title" => $"https://openlibrary.org/search.json?title={Uri.EscapeDataString(query)}&limit={limit}",
            "author" => $"https://openlibrary.org/search.json?author={Uri.EscapeDataString(query)}&limit={limit}",
            "isbn" => $"https://openlibrary.org/search.json?isbn={Uri.EscapeDataString(query)}&limit={limit}",
            _ => $"https://openlibrary.org/search.json?q={Uri.EscapeDataString(query)}&limit={limit}"
        };

        var result = await _http.GetFromJsonAsync<OpenLibrarySearchResult>(url);

        return result?.Docs ?? new();
    }

}
