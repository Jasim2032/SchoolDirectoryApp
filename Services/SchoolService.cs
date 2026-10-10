using System.Net.Http.Json;
using SchoolDirectoryApp.Models;

namespace SchoolDirectoryApp.Services;

public class SchoolService
{
    private readonly HttpClient _http;

    public SchoolService(HttpClient http) => _http = http;

    public async Task<List<School>> GetSchoolsAsync()
    {
      //  await Task.Delay(5000);   // TEMPORARY
        var result = await _http.GetFromJsonAsync<List<School>>("api/school");
        return result ?? new List<School>();
    }
}