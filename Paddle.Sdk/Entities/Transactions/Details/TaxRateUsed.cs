using System.Text.Json.Serialization;

namespace Paddle.Sdk.Entities.Transactions.Details;

public class TaxRateUsed
{
    [JsonPropertyName("totals")]
    public required BaseTotals Totals { get; set; }

    [JsonPropertyName("tax_rate")]
    public required string TaxRate { get; set; }
}