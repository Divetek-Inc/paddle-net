using System.Text.Json.Serialization;

namespace Paddle.Sdk.Entities.Transactions.Details;

public class BaseTotals
{
    [JsonPropertyName("tax")]
    public required string Tax { get; set; }

    [JsonPropertyName("total")]
    public required string Total { get; set; }

    [JsonPropertyName("discount")]
    public required string Discount { get; set; }

    [JsonPropertyName("subtotal")]
    public required string Subtotal { get; set; }
}