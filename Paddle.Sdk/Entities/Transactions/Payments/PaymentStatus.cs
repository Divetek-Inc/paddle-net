using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Paddle.Sdk.Json.Converters;

namespace Paddle.Sdk.Entities.Transactions.Payments;

[JsonConverter(typeof(PaddleJsonConverter<PaymentStatus>))]
public enum PaymentStatus {
    [EnumMember(Value = "authorized")]
    [Description("Authorized but not captured. Payment attempt is incomplete.")]
    Authorized,

    [EnumMember(Value = "authorized_flagged")]
    [Description("Authorized but not captured because it has been flagged as potentially fraudulent. Payment attempt is incomplete.")]
    AuthorizedFlagged,

    [EnumMember(Value = "canceled")]
    [Description("Previously authorized payment attempt has been canceled. Typically when authorized_flagged payment attempts are rejected.")]
    Canceled,

    [EnumMember(Value = "captured")]
    [Description("Payment captured successfully. Payment attempt is complete.")]
    Captured,

    [EnumMember(Value = "error")]
    [Description("Something went wrong and the payment attempt was unsuccessful. Check the error_code for more information.")]
    Error,

    [EnumMember(Value = "action_required")]
    [Description("Customer must complete an action for this payment attempt to proceed. Typically means that the payment attempt requires 3DS.")]
    ActionRequired,

    [EnumMember(Value = "pending_no_action_required")]
    [Description("Response required from the bank or payment provider. Transaction is pending.")]
    PendingNoActionRequired,

    [EnumMember(Value = "created")]
    [Description("New payment attempt created.")]
    Created,

    [EnumMember(Value = "unknown")]
    [Description("Payment attempt status not known.")]
    Unknown,

    [EnumMember(Value = "dropped")]
    [Description("Payment attempt dropped by Paddle.")]
    Dropped
}