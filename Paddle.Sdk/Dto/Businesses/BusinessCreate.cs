using System.Text.Json.Serialization;
using Paddle.Sdk.Entities.Businesses;

namespace Paddle.Sdk.Dto.Businesses;

public class BusinessCreate {
    public required string Name { get; set; }

    [JsonPropertyName("company_number")]
    public string? CompanyNumber { get; set; }

    [JsonPropertyName("tax_identifier")]
    public string? TaxNumber { get; set; }

    [JsonPropertyName("contacts")]
    public List<BusinessContact>? Contacts { get; set; }

    [JsonPropertyName("custom_data")]
    public Dictionary<string, object> CustomData { get; set; }
}