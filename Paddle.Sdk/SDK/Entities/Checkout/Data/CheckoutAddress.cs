using System.Text.Json.Serialization;

namespace Paddle.Sdk.SDK.Entities.Checkout.Data;

public class CheckoutAddress
{
    public required string Id { get; set; }
    
    [JsonPropertyName("country_code")]
    public required string CountryCode { get; set; }
    
    [JsonPropertyName("postal_code")]
    public required string PostalCode { get; set; }
    
    public required string City { get; set; }
    public required string Region { get; set; }
    
    [JsonPropertyName("first_line")]
    public required string FirstLine { get; set; }
}