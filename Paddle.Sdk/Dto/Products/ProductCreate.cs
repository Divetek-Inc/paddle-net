using System.Text.Json.Serialization;
using Paddle.Sdk.Entities.Products;

namespace Paddle.Sdk.Dto.Products;

public class ProductCreate : ProductBase {
    public override required string Name { get; set; }

    [JsonPropertyName("tax_category")]
    public override required TaxCategory TaxCategory { get; set; }
}