using System.Text.Json.Serialization;
using Paddle.Sdk.Entities.Prices;
using Paddle.Sdk.Entities.Shared;
using Paddle.Sdk.Entities.Subscriptions;

namespace Paddle.Sdk.Dto.Subscriptions;

public class SubscriptionUpdate {
    [JsonPropertyName("items")]
    public List<SubscriptionItemUpdate> Items { get; set; }

    [JsonPropertyName("customer_id")]
    public string? CustomerId { get; set; }

    [JsonPropertyName("address_id")]
    public string? AddressId { get; set; }

    [JsonPropertyName("business_id")]
    public string? BusinessId { get; set; }

    [JsonPropertyName("currency_code")]
    public CurrencyCode? CurrencyCode { get; set; }

    [JsonPropertyName("next_billed_at")]
    public DateTimeOffset? NextBilledAt { get; set; }

    [JsonPropertyName("collection_mode")]
    public CollectingMode? CollectionMode { get; set; }

    [JsonPropertyName("billing_details")]
    public BillingDetails? BillingDetails { get; set; }

    [JsonPropertyName("custom_data")]
    public Dictionary<string, object>? CustomData { get; set; }

    [JsonPropertyName("proration_billing_mode")]
    public ProrationBillingMode ProrationBillingMode { get; set; }

    [JsonPropertyName("on_payment_failure")]
    public OnPaymentFailure OnPaymentFailure { get; set; }
}