using System.ComponentModel;
using System.Text.Json.Serialization;
using Paddle.Sdk.Entities.Subscriptions;

namespace Paddle.Sdk.Dto.Subscriptions;

public class SubscriptionPause {
    [JsonPropertyName("effective_from")]
    [Description("When this subscription change should take effect from. Defaults to next_billing_period for active subscriptions, which creates a scheduled_change to apply the subscription change at the end of the billing period.")]
    public required EffectiveFrom EffectiveFrom { get; set; } = EffectiveFrom.Immediately;

    [JsonPropertyName("resume_at")]
    [Description("RFC 3339 datetime string of when the paused subscription should resume. Omit to pause indefinitely until resumed.")]
    public DateTimeOffset? ResumeAt { get; set; }

    [JsonPropertyName("on_resume")]
    [Description("How Paddle should set the billing period for the subscription when resuming. If omitted, defaults to start_new_billing_period.")]
    public OnResume OnResume { get; set; } = OnResume.StartNewBillingPeriod;
}