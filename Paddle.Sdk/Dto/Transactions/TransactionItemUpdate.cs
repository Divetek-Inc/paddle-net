using System.Text.Json.Serialization;

namespace Paddle.Sdk.Dto.Transactions;

public class TransactionItemUpdate {
    /// <summary>
    /// The price ID for this item
    /// </summary>
    [JsonPropertyName("price_id")]
    public required string PriceId { get; set; }

    /// <summary>
    /// The quantity of this item
    /// </summary>
    [JsonPropertyName("quantity")]
    public required int Quantity { get; set; }
}