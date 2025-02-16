using System.Text.Json.Serialization;

namespace Paddle.Sdk.Entities.Shared;

public class BillingPeriod {
    [JsonPropertyName("starts_at")]
    public DateTimeOffset StartsAt { get; set; }

    [JsonPropertyName("ends_at")]
    public DateTimeOffset EndsAt { get; set; }
}