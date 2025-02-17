using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Paddle.Sdk.Json.Converters;

namespace Paddle.Sdk.Entities.Subscriptions;

[JsonConverter(typeof(PaddleJsonConverter<EffectiveFrom>))]
public enum EffectiveFrom
{
    [EnumMember(Value = "next_billing_period")]
    [Description("Takes effect on the next billing period")]
    NextBillingPeriod,

    [EnumMember(Value = "immediately")]
    [Description("Takes effect immediately")]
    Immediately
}
