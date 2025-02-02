using System.Text.Json.Serialization;
using Paddle.Sdk.Dto.Shared.Values;

namespace Paddle.Sdk.Dto.Products;

public class Product : ProductBase {
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("type")]
    public ProductType Type { get; set; }
}