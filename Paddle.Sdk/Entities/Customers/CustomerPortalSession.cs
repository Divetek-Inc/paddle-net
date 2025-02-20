using System.Text.Json.Serialization;

namespace Paddle.Sdk.Entities.Customers;

public class CustomerPortalSession {
    public required string Id { get; set; }

    [JsonPropertyName("customer_id")]
    public required string CustomerId { get; set; }

    public required PortalUrls Urls { get; set; }

    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; set; }
}