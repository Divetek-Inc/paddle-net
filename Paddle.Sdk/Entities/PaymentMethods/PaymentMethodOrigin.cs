using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Paddle.Sdk.Json.Converters;

namespace Paddle.Sdk.Entities.PaymentMethods;

[JsonConverter(typeof(PaddleJsonConverter<PaymentMethodOrigin>))]
public enum PaymentMethodOrigin {
    [EnumMember(Value = "saved_during_purchase")]
    [Description("The customer chose to save this payment method while purchasing a one-time item")]
    SavedDuringPurchase,

    [EnumMember(Value = "subscription")]
    [Description("The customer purchased a subscription, so this payment method was saved for future purchases")]
    Subscription
}