using System.Text.Json.Serialization;
using Paddle.Sdk.Entities.Transactions.Payments;

namespace Paddle.Sdk.SDK.Entities.Checkout.Data;

public class CheckoutPayment
{
    [JsonPropertyName("method_details")]
    public required PaymentMethodDetails MethodDetails { get; set; }
}