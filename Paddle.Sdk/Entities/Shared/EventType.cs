using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Paddle.Sdk.Json.Converters;

namespace Paddle.Sdk.Entities.Shared;

[JsonConverter(typeof(PaddleJsonConverter<EventType>))]
public enum EventType {
    #region Address Events

    [EnumMember(Value = "address.created")]
    AddressCreated,

    [EnumMember(Value = "address.imported")]
    AddressImported,

    [EnumMember(Value = "address.updated")]
    AddressUpdated,

    #endregion

    #region Adjustment Events

    [EnumMember(Value = "adjustment.created")]
    AdjustmentCreated,

    [EnumMember(Value = "adjustment.updated")]
    AdjustmentUpdated,

    #endregion

    #region Business Events

    [EnumMember(Value = "business.created")]
    BusinessCreated,

    [EnumMember(Value = "business.imported")]
    BusinessImported,

    [EnumMember(Value = "business.updated")]
    BusinessUpdated,

    #endregion

    #region Customer Events

    [EnumMember(Value = "customer.created")]
    CustomerCreated,

    [EnumMember(Value = "customer.imported")]
    CustomerImported,

    [EnumMember(Value = "customer.updated")]
    CustomerUpdated,

    #endregion

    #region Discount Events

    [EnumMember(Value = "discount.created")]
    DiscountCreated,

    [EnumMember(Value = "discount.imported")]
    DiscountImported,

    [EnumMember(Value = "discount.updated")]
    DiscountUpdated,

    #endregion

    #region Payout Events

    [EnumMember(Value = "payout.created")]
    PayoutCreated,

    [EnumMember(Value = "payout.paid")]
    PayoutPaid,

    #endregion

    #region Price Events

    [EnumMember(Value = "price.created")]
    PriceCreated,

    [EnumMember(Value = "price.imported")]
    PriceImported,

    [EnumMember(Value = "price.updated")]
    PriceUpdated,

    #endregion

    #region Product Events

    [EnumMember(Value = "product.created")]
    ProductCreated,

    [EnumMember(Value = "product.imported")]
    ProductImported,

    [EnumMember(Value = "product.updated")]
    ProductUpdated,

    #endregion

    #region Report Events

    [EnumMember(Value = "report.created")]
    ReportCreated,

    [EnumMember(Value = "report.updated")]
    ReportUpdated,

    #endregion

    #region Subscription Events

    [EnumMember(Value = "subscription.activated")]
    SubscriptionActivated,

    [EnumMember(Value = "subscription.canceled")]
    SubscriptionCancelled,

    [EnumMember(Value = "subscription.created")]
    SubscriptionCreated,

    [EnumMember(Value = "subscription.imported")]
    SubscriptionImported,

    [EnumMember(Value = "subscription.past_due")]
    SubscriptionPastDue,

    [EnumMember(Value = "subscription.paused")]
    SubscriptionPaused,

    [EnumMember(Value = "subscription.resumed")]
    SubscriptionResumed,

    [EnumMember(Value = "subscription.trialing")]
    SubscriptionTrialing,

    [EnumMember(Value = "subscription.updated")]
    SubscriptionUpdated,

    #endregion

    #region Transaction Events

    [EnumMember(Value = "transaction.billed")]
    TransactionBilled,

    [EnumMember(Value = "transaction.canceled")]
    TransactionCanceled,

    [EnumMember(Value = "transaction.completed")]
    TransactionCompleted,

    [EnumMember(Value = "transaction.created")]
    TransactionCreated,

    [EnumMember(Value = "transaction.paid")]
    TransactionPaid,

    [EnumMember(Value = "transaction.past_due")]
    TransactionPastDue,

    [EnumMember(Value = "transaction.payment_failed")]
    TransactionPaymentFailed,

    [EnumMember(Value = "transaction.ready")]
    TransactionReady,

    [EnumMember(Value = "transaction.updated")]
    TransactionUpdated

    #endregion
}