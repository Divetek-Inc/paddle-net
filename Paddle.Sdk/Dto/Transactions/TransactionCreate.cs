using System.Text.Json.Serialization;
using Paddle.Sdk.Entities.Prices;
using Paddle.Sdk.Entities.Shared;
using Paddle.Sdk.Entities.Transactions;

namespace Paddle.Sdk.Dto.Transactions;

public class TransactionCreate {
    [JsonPropertyName("customer_id")]
    public string? CustomerId { get; set; }

    [JsonPropertyName("address_id")]
    public string? AddressId { get; set; }

    [JsonPropertyName("business_id")]
    public string? BusinessId { get; set; }

    [JsonPropertyName("custom_data")]
    public Dictionary<string, object>? CustomData { get; set; }

    [JsonPropertyName("collection_mode")]
    public CollectingMode CollectionMode { get; set; } = CollectingMode.Automatic;

    [JsonPropertyName("currency_code")]
    public CurrencyCode CurrencyCode { get; set; }

    [JsonPropertyName("discount_id")]
    public string? DiscountId { get; set; }

    public List<TransactionItem> Items { get; set; } = new();

    [JsonPropertyName("billing_details")]
    public BillingDetails? BillingDetails { get; set; }

    [JsonPropertyName("billing_period")]
    public BillingPeriod? BillingPeriod { get; set; }
}