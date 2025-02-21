using Paddle.Sdk.Entities.Prices;
using Paddle.Sdk.Entities.Shared;
using Paddle.Sdk.Entities.Transactions;
using System.Text.Json.Serialization;

namespace Paddle.Sdk.Dto.Transactions;

public class TransactionUpdate {
    /// <summary>
    /// Status of the transaction. Can only be set to "billed" or "canceled".
    /// </summary>
    [JsonPropertyName("status")]
    public TransactionStatus? Status { get; set; }

    /// <summary>
    /// Customer ID associated with this transaction
    /// </summary>
    [JsonPropertyName("customer_id")]
    public string? CustomerId { get; set; }

    /// <summary>
    /// Address ID for this transaction
    /// </summary>
    [JsonPropertyName("address_id")]
    public string? AddressId { get; set; }

    /// <summary>
    /// Business ID for this transaction
    /// </summary>
    [JsonPropertyName("business_id")]
    public string? BusinessId { get; set; }

    /// <summary>
    /// Custom data for the transaction
    /// </summary>
    [JsonPropertyName("custom_data")]
    public Dictionary<string, object>? CustomData { get; set; }

    /// <summary>
    /// Collection mode for the transaction
    /// </summary>
    [JsonPropertyName("collection_mode")]
    public CollectingMode? CollectionMode { get; set; }

    /// <summary>
    /// Currency code for the transaction
    /// </summary>
    [JsonPropertyName("currency_code")]
    public CurrencyCode? CurrencyCode { get; set; }

    /// <summary>
    /// Discount ID to apply to the transaction
    /// </summary>
    [JsonPropertyName("discount_id")]
    public string? DiscountId { get; set; }

    /// <summary>
    /// Billing details for the transaction
    /// </summary>
    [JsonPropertyName("billing_details")]
    public BillingDetails? BillingDetails { get; set; }

    /// <summary>
    /// Items included in the transaction
    /// </summary>
    [JsonPropertyName("items")]
    public List<TransactionItemUpdate>? Items { get; set; }
}