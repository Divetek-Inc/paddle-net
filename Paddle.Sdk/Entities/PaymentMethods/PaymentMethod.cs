using System.ComponentModel;
using System.Text.Json.Serialization;
using Paddle.Sdk.Entities.Shared;
using Paddle.Sdk.Entities.Transactions.Payments;

namespace Paddle.Sdk.Entities.PaymentMethods;

public class PaymentMethod {
    [Description("Unique Paddle ID for this payment method entity, prefixed with paymtd_.")]
    public required string Id { get; set; }

    [JsonPropertyName("customer_id")]
    public required string CustomerId { get; set; }

    [JsonPropertyName("address_id")]
    public required string AddressId { get; set; }

    public required PaymentMethodType Type { get; set; }

    public CardDetails? Card { get; set; }

    public PaypalData? Paypal { get; set; }

    public required PaymentMethodOrigin Origin { get; set; }

    [JsonPropertyName("saved_at")]
    public required DateTimeOffset SavedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public required DateTimeOffset UpdatedAt { get; set; }
}