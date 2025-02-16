using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Paddle.Sdk.Json.Converters;

namespace Paddle.Sdk.Entities;

[JsonConverter(typeof(PaddleJsonConverter<PaddleEvent>))]
public enum PaddleEvent {
    [EnumMember(Value = "subscription.activated")]
    SubscriptionActivated,

    [EnumMember(Value = "subscription.created")]
    SubscriptionCreated,

    [EnumMember(Value = "subscription.updated")]
    SubscriptionUpdated,

    [EnumMember(Value = "subscription.cancelled")]
    SubscriptionCancelled,

    [EnumMember(Value = "subscription.past_due")]
    SubscriptionExpired,

    [EnumMember(Value = "subscription.paused")]
    SubscriptionPaused,

    [EnumMember(Value = "subscription.Resumed")]
    SubscriptionResumed,

    [EnumMember(Value = "transaction.paid")]
    TransactionPaid,

    [EnumMember(Value = "transaction.completed")]
    TransactionCompleted,

    [EnumMember(Value = "transaction.payment_failed")]
    TransactionPaymentFailed
}