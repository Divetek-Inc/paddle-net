using System.Text.Json.Serialization;

namespace Paddle.Sdk.Dto.Transactions;

public class TransactionCheckoutRequest
{
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
