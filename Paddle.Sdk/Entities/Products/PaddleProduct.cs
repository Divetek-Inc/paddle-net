using System.ComponentModel;
using System.Text.Json.Serialization;
using Paddle.Sdk.Entities.Prices;

namespace Paddle.Sdk.Entities.Products;

public class PaddleProduct : ProductBase {
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("type")]
    public ProductType Type { get; set; }

    [Description("Returned when the include parameter is used with the prices value.")]
    public List<PaddlePrice>? Prices { get; set; }
}