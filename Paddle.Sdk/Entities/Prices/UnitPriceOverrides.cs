using System.Text.Json.Serialization;
using Paddle.Sdk.Entities.Shared;

namespace Paddle.Sdk.Entities.Prices;

public class UnitPriceOverrides {
    [JsonPropertyName("country_codes")]
    public List<CountryCode> CountryCodes { get; set; }

    [JsonPropertyName("unit_price")]
    public UnitPrice UnitPrice { get; set; }
}