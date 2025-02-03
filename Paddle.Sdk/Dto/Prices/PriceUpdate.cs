using System.Text.Json.Serialization;
using Paddle.Sdk.Entities.Prices;

namespace Paddle.Sdk.Dto.Prices;

public class PriceUpdate : PriceBase {
    [JsonPropertyName("status")]
    public static string Status { get; set; }
}