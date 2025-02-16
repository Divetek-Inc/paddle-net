using System.Text.Json.Serialization;

namespace Paddle.Sdk.Entities.Transactions.Details;

public class AdjustedTotals
{
    [JsonPropertyName("fee")]
    public required string Fee { get; set; }

    [JsonPropertyName("tax")]
    public required string Tax { get; set; }

    [JsonPropertyName("total")]
    public required string Total { get; set; }

    [JsonPropertyName("earnings")]
    public required string Earnings { get; set; }

    [JsonPropertyName("subtotal")]
    public required string Subtotal { get; set; }

    [JsonPropertyName("grand_total")]
    public required string GrandTotal { get; set; }

    [JsonPropertyName("currency_code")]
    public required string CurrencyCode { get; set; }
}