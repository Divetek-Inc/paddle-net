using System.ComponentModel;
using System.Text.Json.Serialization;
using Paddle.Sdk.Entities.Subscriptions;

namespace Paddle.Sdk.Dto.Subscriptions;

public class SubscriptionResume {
    [JsonPropertyName("effective_from")]
    [Description(
        "When this scheduled change should take effect from. RFC 3339 datetime string of when the subscription should resume.\n\nValid where subscriptions are active with a scheduled change to pause, or where they have the status of paused.")]
    public required EffectiveFrom EffectiveFrom { get; set; } = EffectiveFrom.Immediately;

    [JsonPropertyName("on_resume")]
    [Description("How Paddle should set the billing period for the subscription when resuming. If omitted, defaults to start_new_billing_period.")]
    public OnResume? OnResume { get; set; }
}