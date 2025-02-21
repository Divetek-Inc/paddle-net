using System.Text.Json.Serialization;
using Paddle.Sdk.Entities.Businesses;
using Paddle.Sdk.Entities.Shared.Values;

namespace Paddle.Sdk.Dto.Businesses;

public class BusinessUpdate {
    public string? Name { get; set; }

    [JsonPropertyName("company_number")]
    public string? CompanyNumber { get; set; }

    [JsonPropertyName("tax_identifier")]
    public string? TaxNumber { get; set; }

    [JsonPropertyName("contact")]
    public List<BusinessContact>? Contacts { get; set; }

    [JsonPropertyName("custom_data")]
    public Dictionary<string, object> CustomData { get; set; }

    public Status Status { get; set; }
}