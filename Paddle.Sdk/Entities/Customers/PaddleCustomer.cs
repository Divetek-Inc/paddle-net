using System.Text.Json.Serialization;

namespace Paddle.Sdk.Entities.Customers;

public class PaddleCustomer : CustomerBase {
    public string Id { get; set; }

    public override required string Email { get; set; }

    [JsonPropertyName("marketing_consent")]
    public bool MarketingConsent { get; set; }
}