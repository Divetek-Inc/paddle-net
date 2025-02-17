using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Paddle.Sdk.Json.Converters;

namespace Paddle.Sdk.Entities.Subscriptions;

[JsonConverter(typeof(PaddleJsonConverter<OnPaymentFailure>))]
public enum OnPaymentFailure {
    [EnumMember(Value = "prevent_change")]
    [Description("In case of payment failure, prevent the change to the subscription from applying")]
    PreventChange,

    [EnumMember(Value = "apply_change")]
    [Description("In case of payment failure, apply the change and update the subscription")]
    ApplyChange
}