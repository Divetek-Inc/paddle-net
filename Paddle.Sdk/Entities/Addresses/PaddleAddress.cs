using System.Text.Json.Serialization;
using Paddle.Sdk.Entities.Shared;

namespace Paddle.Sdk.Entities.Addresses;

public class PaddleAddress : AddressBase {
    public required string Id { get; set; }


    [JsonPropertyName("country_code")]
    public override required CountryCode CountryCode { get; set; }
}