using System.Text.Json.Serialization;

namespace Paddle.Sdk.SDK.Entities.Checkout.Data;

public class CheckoutProduct
{
    public required string Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    
    [JsonPropertyName("image_url")]
    public required string ImageUrl { get; set; }
}