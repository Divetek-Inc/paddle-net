using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Paddle.Sdk.Json.Converters;

namespace Paddle.Sdk.Entities.Notifications;

[JsonConverter(typeof(PaddleJsonConverter<NotificationType>))]
public enum NotificationType {
    #region Address Events

    [EnumMember(Value = "address.created")]
    [Description("An address.created event.")]
    AddressCreated,

    [EnumMember(Value = "address.imported")]
    [Description("An address.imported event.")]
    AddressImported,

    [EnumMember(Value = "address.updated")]
    [Description("An address.updated event.")]
    AddressUpdated,

    #endregion

    #region Adjustment Events

    [EnumMember(Value = "adjustment.created")]
    [Description("An adjustment.created event.")]
    AdjustmentCreated,

    [EnumMember(Value = "adjustment.updated")]
    [Description("An adjustment.updated event.")]
    AdjustmentUpdated,

    #endregion

    #region API Key Events

    [EnumMember(Value = "api_key.created")]
    [Description("An api_key.created event.")]
    ApiKeyCreated,

    [EnumMember(Value = "api_key.expired")]
    [Description("An api_key.expired event.")]
    ApiKeyExpired,

    [EnumMember(Value = "api_key.expiring")]
    [Description("An api_key.expiring event.")]
    ApiKeyExpiring,

    [EnumMember(Value = "api_key.revoked")]
    [Description("An api_key.revoked event.")]
    ApiKeyRevoked,

    [EnumMember(Value = "api_key.updated")]
    [Description("An api_key.updated event.")]
    ApiKeyUpdated,

    #endregion

    #region Business Events

    [EnumMember(Value = "business.created")]
    [Description("A business.created event.")]
    BusinessCreated,

    [EnumMember(Value = "business.imported")]
    [Description("A business.imported event.")]
    BusinessImported,

    [EnumMember(Value = "business.updated")]
    [Description("A business.updated event.")]
    BusinessUpdated,

    #endregion

    #region Client Token Events

    [EnumMember(Value = "client_token.created")]
    [Description("A client_token.created event.")]
    ClientTokenCreated,

    [EnumMember(Value = "client_token.revoked")]
    [Description("A client_token.revoked event.")]
    ClientTokenRevoked,

    [EnumMember(Value = "client_token.updated")]
    [Description("A client_token.updated event.")]
    ClientTokenUpdated,

    #endregion

    #region Customer Events

    [EnumMember(Value = "customer.created")]
    [Description("A customer.created event.")]
    CustomerCreated,

    [EnumMember(Value = "customer.imported")]
    [Description("A customer.imported event.")]
    CustomerImported,
    
    [EnumMember(Value = "customer.updated")]
    [Description("A customer.updated event.")]
    CustomerUpdated,

    #endregion

    #region Discount Events

    [EnumMember(Value = "discount.created")]
    [Description("A discount.created event.")]
    DiscountCreated,

    [EnumMember(Value = "discount.imported")]
    [Description("A discount.imported event.")]
    DiscountImported,

    [EnumMember(Value = "discount.updated")]
    [Description("A discount.updated event.")]
    DiscountUpdated,

    [EnumMember(Value = "discount_group.created")]
    [Description("A discount_group.created event.")]
    DiscountGroupCreated,

    #endregion

    #region Payment Method Events

    [EnumMember(Value = "payment_method.saved")]
    [Description("A payment_method.saved event.")]
    PaymentMethodSaved,

    [EnumMember(Value = "payment_method.deleted")]
    [Description("A payment_method.deleted event.")]
    PaymentMethodDeleted,

    #endregion

    #region Payout Events

    [EnumMember(Value = "payout.created")]
    [Description("A payout.created event.")]
    PayoutCreated,

    [EnumMember(Value = "payout.paid")]
    [Description("A payout.paid event.")]
    PayoutPaid,

    #endregion

    #region Price Events

    [EnumMember(Value = "price.created")]
    [Description("A price.created event.")]
    PriceCreated,

    [EnumMember(Value = "price.imported")]
    [Description("A price.imported event.")]
    PriceImported,

    [EnumMember(Value = "price.updated")]
    [Description("A price.updated event.")]
    PriceUpdated,

    #endregion

    #region Product Events

    [EnumMember(Value = "product.created")]
    [Description("A product.created event.")]
    ProductCreated,

    [EnumMember(Value = "product.imported")]
    [Description("A product.imported event.")]
    ProductImported,

    [EnumMember(Value = "product.updated")]
    [Description("A product.updated event.")]
    ProductUpdated,

    #endregion

    #region Report Events

    [EnumMember(Value = "report.created")]
    [Description("A report.created event.")]
    ReportCreated,

    [EnumMember(Value = "report.updated")]
    [Description("A report.updated event.")]
    ReportUpdated,

    #endregion

    #region Subscription Events

    [EnumMember(Value = "subscription.activated")]
    [Description("A subscription.activated event.")]
    SubscriptionActivated,

    [EnumMember(Value = "subscription.canceled")]
    [Description("A subscription.canceled event.")]
    SubscriptionCanceled,

    [EnumMember(Value = "subscription.created")]
    [Description("A subscription.created event.")]
    SubscriptionCreated,

    [EnumMember(Value = "subscription.imported")]
    [Description("A subscription.imported event.")]
    SubscriptionImported,

    [EnumMember(Value = "subscription.past_due")]
    [Description("A subscription.past_due event.")]
    SubscriptionPastDue,

    [EnumMember(Value = "subscription.paused")]
    [Description("A subscription.paused event.")]
    SubscriptionPaused,

    [EnumMember(Value = "subscription.resumed")]
    [Description("A subscription.resumed event.")]
    SubscriptionResumed,

    [EnumMember(Value = "subscription.trialing")]
    [Description("A subscription.trialing event.")]
    SubscriptionTrialing,

    [EnumMember(Value = "subscription.updated")]
    [Description("A subscription.updated event.")]
    SubscriptionUpdated,

    #endregion

    #region Transaction Events

    [EnumMember(Value = "transaction.billed")]
    [Description("A transaction.billed event.")]
    TransactionBilled,

    [EnumMember(Value = "transaction.canceled")]
    [Description("A transaction.canceled event.")]
    TransactionCanceled,

    [EnumMember(Value = "transaction.completed")]
    [Description("A transaction.completed event.")]
    TransactionCompleted,

    [EnumMember(Value = "transaction.created")]
    [Description("A transaction.created event.")]
    TransactionCreated,

    [EnumMember(Value = "transaction.paid")]
    [Description("A transaction.paid event.")]
    TransactionPaid,

    [EnumMember(Value = "transaction.past_due")]
    [Description("A transaction.past_due event.")]
    TransactionPastDue,

    [EnumMember(Value = "transaction.payment_failed")]
    [Description("A transaction.payment_failed event.")]
    TransactionPaymentFailed,

    [EnumMember(Value = "transaction.ready")]
    [Description("A transaction.ready event.")]
    TransactionReady,

    [EnumMember(Value = "transaction.revised")]
    [Description("A transaction.revised event.")]
    TransactionRevised,

    [EnumMember(Value = "transaction.updated")]
    [Description("A transaction.updated event.")]
    TransactionUpdated

    #endregion
}