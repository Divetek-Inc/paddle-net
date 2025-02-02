using System.Text.Json.Serialization;
using Paddle.Sdk.Dto.Shared;

namespace Paddle.Sdk.Dto.Prices;

public class UnitPriceOverrides {
    [JsonPropertyName("country_codes")]
    public CountryCodes CountryCodes { get; set; }

    [JsonPropertyName("unit_price")]
    public UnitPrice UnitPrice { get; set; }
}