using System.Text.Json.Serialization;
using Paddle.Sdk.Entities.Shared;

namespace Paddle.Sdk.Entities.Addresses;

public class AddressBase : PaddleBaseEntity {
    [JsonPropertyName("country_code")]
    public virtual CountryCode CountryCode { get; set; }

    public string? Description { get; set; }

    [JsonPropertyName("first_line")]
    public string? FirstLine { get; set; }

    [JsonPropertyName("second_line")]
    public string? SecondLine { get; set; }

    [JsonPropertyName("city")]
    public string? City { get; set; }

    [JsonPropertyName("postal_code")]
    public string? PostalCode { get; set; }

    public string? Region { get; set; }
}