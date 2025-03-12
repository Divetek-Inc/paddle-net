using System.Text.Json.Serialization;

namespace Paddle.Sdk.SDK.Entities.Checkout.Data;

public class CheckoutSettings
{
    [JsonPropertyName("display_mode")]
    public required string DisplayMode { get; set; }
    
    public required string Theme { get; set; }
    
    public required string Variant { get; set; }
}