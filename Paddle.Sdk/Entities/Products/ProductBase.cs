using System.Text.Json.Serialization;

namespace Paddle.Sdk.Entities.Products;

public class ProductBase : PaddleBaseEntity {
    public virtual string Name { get; set; }

    [JsonPropertyName("tax_category")]
    public virtual TaxCategory TaxCategory { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("image_url")]
    public Uri? ImageUrl { get; set; }
}