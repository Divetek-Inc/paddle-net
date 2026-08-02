using System.Text.Json.Serialization;
using Paddle.Sdk.Entities.Prices;
using Paddle.Sdk.Entities.Subscriptions;

namespace Paddle.Sdk.Dto.Subscriptions;

public sealed class SubscriptionCharge {
    [JsonPropertyName("effective_from")]
    public required EffectiveFrom EffectiveFrom { get; set; }

    [JsonPropertyName("items")]
    public required List<SubscriptionChargeItem> Items { get; set; }
}

public sealed class SubscriptionChargeItem {
    [JsonPropertyName("quantity")]
    public required int Quantity { get; set; }

    [JsonPropertyName("price_id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PriceId { get; set; }

    [JsonPropertyName("price")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public SubscriptionChargeInlinePrice? Price { get; set; }
}

public sealed class SubscriptionChargeInlinePrice {
    [JsonPropertyName("product_id")]
    public required string ProductId { get; set; }

    [JsonPropertyName("description")]
    public required string Description { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("tax_mode")]
    public TaxMode TaxMode { get; set; } = TaxMode.AccountSetting;

    [JsonPropertyName("unit_price")]
    public required UnitPrice UnitPrice { get; set; }

    [JsonPropertyName("quantity")]
    public Quantity Quantity { get; set; } = new() { Minimum = 1, Maximum = 1 };
}
