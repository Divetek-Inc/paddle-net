using System.Text.Json.Serialization;

namespace Paddle.Sdk.Entities.Prices;

public class UnitPrice {
    public required string Amount { get; set; }

    [JsonPropertyName("currency_code")]
    public required string CurrencyCode { get; set; }
}