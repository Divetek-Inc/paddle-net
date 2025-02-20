using System.Text.Json.Serialization;

namespace Paddle.Sdk.Entities.Customers;

public class PortalSubscription {
    public string Id { get; set; }

    [JsonPropertyName("cancel_subscription")]
    public string CancelSubscription { get; set; }

    [JsonPropertyName("update_subscription_payment_method")]
    public string UpdateSubscriptionPaymentMethod { get; set; }
}