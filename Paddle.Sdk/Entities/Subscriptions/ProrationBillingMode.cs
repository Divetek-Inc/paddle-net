using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Paddle.Sdk.Json.Converters;

namespace Paddle.Sdk.Entities.Subscriptions;

[JsonConverter(typeof(PaddleJsonConverter<ProrationBillingMode>))]
public enum ProrationBillingMode {
    [EnumMember(Value = "prorated_immediately")]
    [Description("Paddle calculates the prorated amount for the subscription changes based on the current billing cycle, then creates a transaction to collect immediately")]
    ProratedImmediately,

    [EnumMember(Value = "prorated_next_billing_period")]
    [Description("Paddle calculates the prorated amount for the subscription changes based on the current billing cycle, then schedules them to be billed on the next renewal")]
    ProratedNextBillingPeriod,

    [EnumMember(Value = "full_immediately")]
    [Description("Paddle does not calculate proration for the subscription changes, creating a transaction to collect for the full amount immediately")]
    FullImmediately,

    [EnumMember(Value = "full_next_billing_period")]
    [Description("Paddle does not calculate proration for the subscription changes, scheduling for the full amount for the changes to be billed on the next renewal")]
    FullNextBillingPeriod,

    [EnumMember(Value = "do_not_bill")]
    [Description("Paddle does not bill for the subscription changes")]
    DoNotBill
}