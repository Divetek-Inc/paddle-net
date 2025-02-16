using System.Text.Json.Serialization;

namespace Paddle.Sdk.Entities.Transactions.Payments;

public class Payment {
    public required string Amount { get; set; }

    public required PaymentStatus Status { get; set; }

    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; set; }

    [JsonPropertyName("error_code")]
    public PaymentErrorCode? ErrorCode { get; set; }

    [JsonPropertyName("captured_at")]
    public DateTimeOffset? CapturedAt { get; set; }

    [JsonPropertyName("method_details")]
    public required PaymentMethodDetails MethodDetails { get; set; }

    [JsonPropertyName("payment_method_id")]
    public required string PaymentMethodId { get; set; }

    [JsonPropertyName("payment_attempt_id")]
    public required string PaymentAttemptId { get; set; }

    [JsonPropertyName("stored_payment_method_id")]
    public required string StoredPaymentMethodId { get; set; }
}