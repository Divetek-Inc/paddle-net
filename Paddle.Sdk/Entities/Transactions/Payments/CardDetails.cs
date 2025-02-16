using System.Text.Json.Serialization;

namespace Paddle.Sdk.Entities.Transactions.Payments;

public class CardDetails {
    public required CardType Type { get; set; }

    public required string Last4 { get; set; }

    [JsonPropertyName("expiry_year")]
    public required int ExpiryYear { get; set; }

    [JsonPropertyName("expiry_month")]
    public required int ExpiryMonth { get; set; }

    [JsonPropertyName("cardholder_name")]
    public required string CardholderName { get; set; }
}