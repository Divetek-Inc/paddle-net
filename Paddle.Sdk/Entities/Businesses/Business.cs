using System.Text.Json.Serialization;

namespace Paddle.Sdk.Entities.Businesses;

public class Business : PaddleBaseEntity {
    public required string Id { get; set; }

    [JsonPropertyName("customer_id")]
    public required string CustomerId { get; set; }

    public required string Name { get; set; }

    [JsonPropertyName("tax_identifier")]
    public string? TaxNumber { get; set; }

    public List<BusinessContact> Contacts { get; set; }
}