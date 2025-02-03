using System.Text.Json.Serialization;

namespace Paddle.Sdk.Entities.Products;

public class ProductBase : PaddleBaseEntity {
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("tax_category")]
    public required TaxCategory TaxCategory { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("image_url")]
    public Uri? ImageUrl { get; set; }
}