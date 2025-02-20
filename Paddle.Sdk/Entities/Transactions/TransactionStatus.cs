using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Paddle.Sdk.Json.Converters;

namespace Paddle.Sdk.Entities.Transactions;

[JsonConverter(typeof(PaddleJsonConverter<TransactionStatus>))]
public enum TransactionStatus {
    [EnumMember(Value = "draft")]
    [Description("Transaction is missing required fields. Typically the first stage of a checkout before customer details are captured")]
    Draft,

    [EnumMember(Value = "ready")]
    [Description("Transaction has all of the required fields to be marked as billed or completed")]
    Ready,

    [EnumMember(Value = "billed")]
    [Description("Transaction has been updated to billed. Billed transactions get an invoice number and are considered a legal record. They cannot be changed. Typically used as part of an invoice workflow")]
    Billed,

    [EnumMember(Value = "paid")]
    [Description("Transaction is fully paid, but has not yet been processed internally")]
    Paid,

    [EnumMember(Value = "completed")]
    [Description("Transaction is fully paid and processed")]
    Completed,

    [EnumMember(Value = "canceled")]
    [Description("Transaction has been updated to canceled. If an invoice, it's no longer due")]
    Canceled,

    [EnumMember(Value = "past_due")]
    [Description("Transaction is past due. Occurs for automatically-collected transactions when the related subscription is in dunning, and for manually-collected transactions when payment terms have elapsed")]
    PastDue
}