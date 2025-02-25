using System.Text.Json.Serialization;

namespace Paddle.Sdk.Entities.Prices;

public class PaddlePrice : PriceBase {
    public required string Id { get; set; }

    [JsonPropertyName("product_id")]
    public override required string ProductId { get; set; }

    public override required string Description { get; set; }

    [JsonPropertyName("unit_price")]
    public override required UnitPrice UnitPrice { get; set; }

    [JsonPropertyName("tax_mode")]
    public override required TaxMode TaxMode { get; set; } = TaxMode.AccountSetting;
}