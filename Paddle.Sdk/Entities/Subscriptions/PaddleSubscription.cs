using System.Text.Json.Serialization;
using Paddle.Sdk.Entities.Prices;
using Paddle.Sdk.Entities.Shared;

namespace Paddle.Sdk.Entities.Subscriptions;

public class PaddleSubscription : PaddleBaseEntity {
    public string Id { get; set; }

    public List<SubscriptionItem> Items { get; set; }

    [JsonPropertyName("customer_id")]
    public string CustomerId { get; set; }

    [JsonPropertyName("address_id")]
    public string AddressId { get; set; }

    [JsonPropertyName("business_id")]
    public string? BusinessId { get; set; }

    [JsonPropertyName("currency_code")]
    public CurrencyCode CurrencyCode { get; set; }

    [JsonPropertyName("billing_cycle")]
    public BillingCycle BillingCycle { get; set; }

    [JsonPropertyName("started_at")]
    public DateTimeOffset? StartedAt { get; set; }

    [JsonPropertyName("paused_at")]
    public DateTimeOffset? PausedAt { get; set; }

    [JsonPropertyName("canceled_at")]
    public DateTimeOffset? CanceledAt { get; set; }

    [JsonPropertyName("first_billed_at")]
    public DateTimeOffset? FirstBilledAt { get; set; }

    [JsonPropertyName("next_billed_at")]
    public DateTimeOffset? NextBilledAt { get; set; }

    [JsonPropertyName("current_billing_period")]
    public BillingPeriod BillingPeriod { get; set; }
}