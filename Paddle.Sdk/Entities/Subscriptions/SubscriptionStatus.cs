using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Paddle.Sdk.Json.Converters;

namespace Paddle.Sdk.Entities.Subscriptions;

[JsonConverter(typeof(PaddleJsonConverter<SubscriptionStatus>))]
public enum SubscriptionStatus
{
    [EnumMember(Value = "active")]
    [Description("Subscription is active. Paddle is billing for this subscription and related transactions aren't past due")]
    Active,

    [EnumMember(Value = "canceled")]
    [Description("Subscription is canceled. Automatically set by Paddle when a subscription is canceled. When a subscription is set to cancel on the next billing period, a scheduled change for the cancellation is created. The subscription status moves to canceled when the scheduled change takes effect")]
    Canceled,

    [EnumMember(Value = "past_due")]
    [Description("Subscription has an overdue payment. Automatically set by Paddle when payment fails for an automatically-collected transaction, or when payment terms have elapsed for a manually-collected transaction (an invoice)")]
    PastDue,

    [EnumMember(Value = "paused")]
    [Description("Subscription is paused. Automatically set by Paddle when a subscription is paused. When a subscription is set to pause on the next billing period, a scheduled change for the pause is created. The subscription status moves to paused when the scheduled change takes effect")]
    Paused,

    [EnumMember(Value = "trialing")]
    [Description("Subscription is in trial")]
    Trialing
}
