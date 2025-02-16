using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Paddle.Sdk.Json.Converters;

namespace Paddle.Sdk.Entities.Transactions;

[JsonConverter(typeof(PaddleJsonConverter<TransactionOrigin>))]
public enum TransactionOrigin {
    [EnumMember(Value = "subscription_charge")]
    [Description("Transaction created automatically by Paddle as a result of a one-time charge for a subscription")]
    SubscriptionCharge,

    [EnumMember(Value = "subscription_payment_method_change")]
    [Description("Transaction created automatically as part of updating a payment method. May be a zero value transaction")]
    SubscriptionPaymentMethodChange,

    [EnumMember(Value = "subscription_recurring")]
    [Description("Transaction created automatically by Paddle as a result of a subscription renewal")]
    SubscriptionRecurring,

    [EnumMember(Value = "subscription_update")]
    [Description("Transaction created automatically by Paddle as a result of an update to a subscription")]
    SubscriptionUpdate,

    [EnumMember(Value = "web")]
    [Description("Transaction created automatically by Paddle.js for a checkout")]
    Web
}
