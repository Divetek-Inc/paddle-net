using System.ComponentModel;
using System.Text.Json.Serialization;
using Paddle.Sdk.Entities.Prices;

namespace Paddle.Sdk.Entities.Transactions.Details;

public class ExtendedTotals : BaseTotals {
    [JsonPropertyName("fee")]
    public required string Fee { get; set; }

    [JsonPropertyName("credit")]
    [Description("Total credit applied to this transaction. This includes credits applied using a customer's credit balance and adjustments to a billed transaction.")]
    public required string Credit { get; set; }

    [JsonPropertyName("balance")]
    [Description("Total due on a transaction after credits and any payments.")]
    public required string Balance { get; set; }

    [JsonPropertyName("earnings")]
    public required string Earnings { get; set; }

    [JsonPropertyName("grand_total")]
    public required string GrandTotal { get; set; }

    [JsonPropertyName("currency_code")]
    public required CurrencyCode CurrencyCode { get; set; }

    [JsonPropertyName("credit_to_balance")]
    [Description("Additional credit generated from negative details.line_items. This credit is added to the customer balance.")]
    public required string CreditToBalance { get; set; }
}