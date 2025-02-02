using System.Text.Json.Serialization;

namespace Paddle.Sdk.Dto.Shared;

public class Pagination {
    [JsonPropertyName("per_page")]
    public int PerPage { get; set; }

    [JsonPropertyName("next")]
    public string? Next { get; set; }

    [JsonPropertyName("has_more")]
    public bool HasMore { get; set; }

    [JsonPropertyName("estimated_total")]
    public int EstimatedTotal { get; set; }
}