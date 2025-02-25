using System.Text.Json.Serialization;
using Paddle.Sdk.Entities.Prices;
using Paddle.Sdk.Entities.Products;
using Paddle.Sdk.Entities.Shared.Values;

namespace Paddle.Sdk.Entities.Subscriptions;

public class SubscriptionItem {
    public PaddlePrice Price { get; set; }

    public PaddleProduct Product { get; set; }

    public int Quantity { get; set; }

    public bool Recurring { get; set; }

    public Status Status { get; set; }

    [JsonPropertyName("created_at")]
    public DateTimeOffset CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTimeOffset UpdatedAt { get; set; }

    [JsonPropertyName("next_billed_at")]
    public DateTimeOffset? NextBilledAt { get; set; }

    [JsonPropertyName("previously_billed_at")]
    public DateTimeOffset? PreviouslyBilledAt { get; set; }
}