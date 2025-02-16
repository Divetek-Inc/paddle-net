using System.Text.Json.Serialization;

namespace Paddle.Sdk.Entities.Transactions.Details;

public class ExtendedTotals : BaseTotals
{
    [JsonPropertyName("fee")]
    public required string Fee { get; set; }

    [JsonPropertyName("credit")]
    public required string Credit { get; set; }

    [JsonPropertyName("balance")]
    public required string Balance { get; set; }

    [JsonPropertyName("earnings")]
    public required string Earnings { get; set; }

    [JsonPropertyName("grand_total")]
    public required string GrandTotal { get; set; }

    [JsonPropertyName("currency_code")]
    public required string CurrencyCode { get; set; }

    [JsonPropertyName("credit_to_balance")]
    public required string CreditToBalance { get; set; }
}