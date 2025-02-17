using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Paddle.Sdk.Json.Converters;

namespace Paddle.Sdk.Entities.Subscriptions;

[JsonConverter(typeof(PaddleJsonConverter<OnResume>))]
public enum OnResume
{
    [EnumMember(Value = "continue_existing_billing_period")]
    [Description("When resuming, continue the existing billing period. If the customer resumes before the end date of the existing billing period, there's no immediate charge. If after, an error is returned")]
    ContinueExistingBillingPeriod,

    [EnumMember(Value = "start_new_billing_period")]
    [Description("When resuming, start a new billing period. The current_billing_period.starts_at date is set to the resume date, and Paddle immediately charges the full amount for the new billing period")]
    StartNewBillingPeriod
}
