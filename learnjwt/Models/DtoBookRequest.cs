using System.Text.Json.Serialization;

namespace learnjwt.Models;

public class DtoBookRequest
{
    
    [JsonPropertyName("code")]
    public string Code { get; set; }
    
    [JsonPropertyName("title")]
    public string Title { get; set; }
    
    [JsonPropertyName("desc")]
    public string Desc { get; set; }

    [JsonPropertyName("image")]
    public IFormFile Image { get; set; }
    
    
}