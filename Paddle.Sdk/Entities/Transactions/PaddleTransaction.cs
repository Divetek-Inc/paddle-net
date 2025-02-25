using System.ComponentModel;
using System.Text.Json.Serialization;
using Paddle.Sdk.Entities.Prices;
using Paddle.Sdk.Entities.Shared;
using Paddle.Sdk.Entities.Shared.Values;
using Paddle.Sdk.Entities.Transactions.Details;
using Paddle.Sdk.Entities.Transactions.Payments;

namespace Paddle.Sdk.Entities.Transactions;

public class PaddleTransaction : PaddleBaseEntity {
    public required string Id { get; set; }

    public List<TransactionItem> Items { get; set; }

    public TransactionOrigin Origin { get; set; }

    public new TransactionStatus Status { get; set; }

    public TransactionDetails Details { get; set; }

    public TransactionCheckout Checkout { get; set; }

    public List<Payment> Payments { get; set; }

    [JsonPropertyName("billed_at")]
    public DateTimeOffset BilledAt { get; set; }

    [JsonPropertyName("address_id")]
    public string AddressId { get; set; }

    [JsonPropertyName("invoice_id")]
    public string InvoiceId { get; set; }

    [JsonPropertyName("revised_at")]
    public DateTimeOffset? RevisedAt { get; set; }

    [JsonPropertyName("business_id")]
    public string? BusinessId { get; set; }

    [JsonPropertyName("customer_id")]
    public string CustomerId { get; set; }

    [JsonPropertyName("discount_id")]
    public string? DiscountId { get; set; }

    [JsonPropertyName("currency_code")]
    public required CurrencyCode CurrencyCode { get; set; }

    [JsonPropertyName("billing_period")]
    public BillingPeriod BillingPeriod { get; set; }

    [JsonPropertyName("invoice_number")]
    public string InvoiceNumber { get; set; }

    [JsonPropertyName("billing_details")]
    [Description("Details for invoicing. Required if collection_mode is manual.")]
    public BillingDetails? BillingDetails { get; set; } // Type can be specified once we know the structure

    [JsonPropertyName("collection_mode")]
    public CollectingMode CollectionMode { get; set; }

    [JsonPropertyName("subscription_id")]
    public string? SubscriptionId { get; set; }
}