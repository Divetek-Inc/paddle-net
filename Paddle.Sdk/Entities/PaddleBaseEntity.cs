using System.Text.Json.Serialization;
using Paddle.Sdk.Entities.Shared.Values;

namespace Paddle.Sdk.Entities;

public class PaddleBaseEntity{
    [JsonPropertyName("import_meta")]
    public Dictionary<string, object>? ImportMeta { get; set; }

    [JsonPropertyName("custom_data")]
    public Dictionary<string, object>? CustomData { get; set; }

    [JsonPropertyName("status")]
    public virtual Status Status { get; set; }

    [JsonPropertyName("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTimeOffset? UpdatedAt { get; set; }
}