using System.Text.Json.Serialization;
using Paddle.Sdk.Entities.Products;

namespace Paddle.Sdk.Entities.Transactions.Details;

public class LineItem {
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("totals")]
    public required BaseTotals Totals { get; set; }

    [JsonPropertyName("product")]
    public required Product Product { get; set; }

    [JsonPropertyName("price_id")]
    public required string PriceId { get; set; }

    [JsonPropertyName("quantity")]
    public required int Quantity { get; set; }

    [JsonPropertyName("tax_rate")]
    public required string TaxRate { get; set; }

    [JsonPropertyName("unit_totals")]
    public required BaseTotals UnitTotals { get; set; }
}