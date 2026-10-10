using System.Text.Json.Serialization;

namespace SchoolDirectoryApp.Models;

// Only the fields required by the assignment (not the full API response).
public class School
{
    [JsonPropertyName("schoolId")]
    public int SchoolId { get; set; }

    [JsonPropertyName("schoolName")]
    public string? SchoolName { get; set; }

    [JsonPropertyName("address")]
    public string? Address { get; set; }

    [JsonPropertyName("phoneNo")]
    public string? PhoneNo { get; set; }

    [JsonPropertyName("emailAddress")]
    public string? EmailAddress { get; set; }

    [JsonPropertyName("proprietorFullName")]
    public string? ProprietorFullName { get; set; }

    [JsonPropertyName("headFullName")]
    public string? HeadFullName { get; set; }
}
