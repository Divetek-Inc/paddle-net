using System.Text.Json.Serialization;

namespace Paddle.Sdk.Entities.Shared;

public class Meta {
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }

    [JsonPropertyName("pagination")]
    public Pagination? Pagination { get; set; }
}