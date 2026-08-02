using System.Text.Json.Serialization;
using Paddle.Sdk.Entities.Prices;
using Paddle.Sdk.Entities.Shared;
using Paddle.Sdk.Entities.Products;

namespace Paddle.Sdk.Entities.Subscriptions;

public sealed class SubscriptionChargePreview {
    [JsonPropertyName("immediate_transaction")]
    public SubscriptionChargeTransactionPreview? ImmediateTransaction { get; set; }

    [JsonPropertyName("next_transaction")]
    public SubscriptionChargeTransactionPreview? NextTransaction { get; set; }

    [JsonPropertyName("recurring_transaction_details")]
    public SubscriptionChargeTransactionPreview? RecurringTransactionDetails { get; set; }
}

public sealed class SubscriptionChargeTransactionPreview {
    [JsonPropertyName("billing_period")]
    public required BillingPeriod BillingPeriod { get; set; }

    [JsonPropertyName("details")]
    public required SubscriptionChargePreviewDetails Details { get; set; }
}

public sealed class SubscriptionChargePreviewDetails {
    [JsonPropertyName("totals")]
    public required SubscriptionChargePreviewTotals Totals { get; set; }

    [JsonPropertyName("line_items")]
    public required List<SubscriptionChargePreviewLineItem> LineItems { get; set; }
}

public sealed class SubscriptionChargePreviewLineItem {
    [JsonPropertyName("price_id")]
    public required string PriceId { get; set; }

    [JsonPropertyName("quantity")]
    public required int Quantity { get; set; }

    [JsonPropertyName("totals")]
    public required SubscriptionChargePreviewLineItemTotals Totals { get; set; }

    [JsonPropertyName("product")]
    public required PaddleProduct Product { get; set; }
}

public sealed class SubscriptionChargePreviewLineItemTotals {
    [JsonPropertyName("subtotal")]
    public required string Subtotal { get; set; }

    [JsonPropertyName("discount")]
    public required string Discount { get; set; }

    [JsonPropertyName("tax")]
    public required string Tax { get; set; }

    [JsonPropertyName("total")]
    public required string Total { get; set; }
}

public sealed class SubscriptionChargePreviewTotals {
    [JsonPropertyName("subtotal")]
    public required string Subtotal { get; set; }

    [JsonPropertyName("discount")]
    public required string Discount { get; set; }

    [JsonPropertyName("tax")]
    public required string Tax { get; set; }

    [JsonPropertyName("total")]
    public required string Total { get; set; }

    [JsonPropertyName("credit")]
    public required string Credit { get; set; }

    [JsonPropertyName("balance")]
    public required string Balance { get; set; }

    [JsonPropertyName("grand_total")]
    public required string GrandTotal { get; set; }

    [JsonPropertyName("currency_code")]
    public required CurrencyCode CurrencyCode { get; set; }
}
