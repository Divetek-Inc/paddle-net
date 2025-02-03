using System.Reflection.Metadata.Ecma335;
using System.Text.Json.Serialization;

namespace Paddle.Sdk.Entities.Customers;

public class CustomerAuthToken {
    [JsonPropertyName("customer_auth_token")]
    public string AuthToken { get; set; }

    [JsonPropertyName("expires_at")]
    public DateTimeOffset? ExpiresAt { get; set; }
}