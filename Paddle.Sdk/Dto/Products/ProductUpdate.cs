using System.Text.Json.Serialization;

namespace Paddle.Sdk.Dto.Products;

public class ProductUpdate : ProductBase {
    [JsonPropertyName("status")]
    public static string Status { get; set; }
}