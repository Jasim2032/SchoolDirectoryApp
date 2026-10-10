using System.Net.Http.Json;
using SchoolDirectoryApp.Models;

namespace SchoolDirectoryApp.Services;

public class SchoolService
{
    private readonly HttpClient _http;

    public SchoolService(HttpClient http) => _http = http;

    // Throws HttpRequestException on failure -> handled in Schools.razor
    public async Task<List<School>> GetSchoolsAsync()
    {
        var result = await _http.GetFromJsonAsync<List<School>>("api/school");
        return result ?? new List<School>();
    }
}
