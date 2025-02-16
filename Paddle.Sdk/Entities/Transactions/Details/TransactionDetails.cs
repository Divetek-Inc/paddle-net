using System.Text.Json.Serialization;

namespace Paddle.Sdk.Entities.Transactions.Details;

public class TransactionDetails
{
    [JsonPropertyName("totals")]
    public required ExtendedTotals Totals { get; set; }

    [JsonPropertyName("line_items")]
    public required List<LineItem> LineItems { get; set; }

    [JsonPropertyName("payout_totals")]
    public required ExtendedTotals PayoutTotals { get; set; }

    [JsonPropertyName("tax_rates_used")]
    public required List<TaxRateUsed> TaxRatesUsed { get; set; }

    [JsonPropertyName("adjusted_totals")]
    public required AdjustedTotals AdjustedTotals { get; set; }
}