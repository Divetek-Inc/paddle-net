using System.ComponentModel;
using System.Text.Json.Serialization;
using Paddle.Sdk.Entities.Subscriptions;

namespace Paddle.Sdk.Dto.Subscriptions;

public class SubscriptionCancel {
    [JsonPropertyName("effective_from")]
    [Description("When this subscription change should take effect from. Defaults to next_billing_period for active subscriptions, which creates a scheduled_change to apply the subscription change at the end of the billing period.")]
    public EffectiveFrom? EffectiveFrom { get; set; }
}