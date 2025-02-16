using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Paddle.Sdk.Json.Converters;

namespace Paddle.Sdk.Entities.Transactions.Payments;

[JsonConverter(typeof(PaddleJsonConverter<PaymentErrorCode>))]
public enum PaymentErrorCode
{
    [EnumMember(Value = "already_canceled")]
    [Description("Cancellation not possible because the amount has already been canceled. Not typically returned for payments.")]
    AlreadyCanceled,

    [EnumMember(Value = "already_refunded")]
    [Description("Refund is not possible because the amount has already been refunded. Not typically returned for payments.")]
    AlreadyRefunded,

    [EnumMember(Value = "authentication_failed")]
    [Description("Payment required a 3DS2 authentication challenge. The customer completed the challenge but was not successful.")]
    AuthenticationFailed,

    [EnumMember(Value = "blocked_card")]
    [Description("Payment method issuer has indicated that the card cannot be used as it is frozen, lost, damaged, or stolen.")]
    BlockedCard,

    [EnumMember(Value = "canceled")]
    [Description("Customer has requested that the mandate for recurring payments be canceled.")]
    Canceled,

    [EnumMember(Value = "declined")]
    [Description("Payment method has been declined, with no other information returned.")]
    Declined,

    [EnumMember(Value = "declined_not_retryable")]
    [Description("Payment method has been declined, and the issuer has indicated that it should not be retried. This could mean the account is closed or the customer revoked authorization to charge the payment method.")]
    DeclinedNotRetryable,

    [EnumMember(Value = "expired_card")]
    [Description("Payment method issuer has indicated that this card is expired. Expired cards may also return invalid_payment_details, depending on how a payment is routed.")]
    ExpiredCard,

    [EnumMember(Value = "fraud")]
    [Description("Payment method issuer or payment service provider flagged this payment as potentially fraudulent.")]
    Fraud,

    [EnumMember(Value = "invalid_amount")]
    [Description("Payment method issuer or payment service provider cannot process a payment that is this high or low.")]
    InvalidAmount,

    [EnumMember(Value = "invalid_payment_details")]
    [Description("Payment service provider has indicated the payment method isn't valid. This typically means that it's expired. expired_card is returned by the payment method issuer, rather than the payment service provider.")]
    InvalidPaymentDetails,

    [EnumMember(Value = "issuer_unavailable")]
    [Description("Payment service provider couldn't reach the payment method issuer.")]
    IssuerUnavailable,

    [EnumMember(Value = "not_enough_balance")]
    [Description("Payment method declined because of insufficient funds, or fund limits being reached.")]
    NotEnoughBalance,

    [EnumMember(Value = "preferred_network_not_supported")]
    [Description("Payment method has been declined because the network scheme that the customer selected isn't supported by the payment service provider.")]
    PreferredNetworkNotSupported,

    [EnumMember(Value = "psp_error")]
    [Description("Something went wrong with the payment service provider, with no other information returned.")]
    PspError,

    [EnumMember(Value = "redacted_payment_method")]
    [Description("Payment service provider didn't receive payment method information as they've been redacted.")]
    RedactedPaymentMethod,

    [EnumMember(Value = "system_error")]
    [Description("Something went wrong with the Paddle platform. Try again later, or check status.paddle.com.")]
    SystemError,

    [EnumMember(Value = "transaction_not_permitted")]
    [Description("Payment method issuer doesn't allow this kind of payment because of limits on the account, or legal or compliance reasons.")]
    TransactionNotPermitted,

    [EnumMember(Value = "unknown")]
    [Description("Payment attempt unsuccessful, with no other information returned.")]
    Unknown
}
