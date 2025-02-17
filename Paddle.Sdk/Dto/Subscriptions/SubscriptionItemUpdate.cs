using System.Text.Json.Serialization;

namespace Paddle.Sdk.Dto.Subscriptions;

public class SubscriptionItemUpdate {
    [JsonPropertyName("price_id")]
    public string PriceId { get; set; }

    public int? Quantity { get; set; }
}