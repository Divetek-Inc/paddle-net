using System.Text.Json.Serialization;
using Paddle.Sdk.Entities.Prices;
using Paddle.Sdk.SDK.Entities.Checkout.Data;

namespace Paddle.Sdk.SDK.Entities.Checkout;

public class PaddleCompletedCheckout {
    public required string Id { get; set; }

    [JsonPropertyName("transaction_id")]
    public required string TransactionId { get; set; }

    public required string Status { get; set; }

    [JsonPropertyName("custom_data")]
    public Dictionary<string, object>? CustomData { get; set; }

    [JsonPropertyName("currency_code")]
    public required CurrencyCode CurrencyCode { get; set; }

    public required CheckoutCustomer Customer { get; set; }

    public required List<CheckoutItem> Items { get; set; }

    public required CheckoutTotals Totals { get; set; }

    public required CheckoutPayment Payment { get; set; }

    public required CheckoutSettings Settings { get; set; }

    [JsonPropertyName("recurring_totals")]
    public required CheckoutTotals RecurringTotals { get; set; }
}