using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Paddle.Sdk.Json.Converters;

namespace Paddle.Sdk.Entities.Notifications;

[JsonConverter(typeof(PaddleJsonConverter<NotificationStatus>))]
public enum NotificationStatus {
    [EnumMember(Value = "not_attempted")]
    [Description("Paddle hasn't yet tried to deliver this notification.")]
    NotAttempted,

    [EnumMember(Value = "needs_retry")]
    [Description("Paddle tried to deliver this notification, but it failed. It's scheduled to be retried.")]
    NeedsRetry,

    [EnumMember(Value = "delivered")]
    [Description("Paddle delivered this notification successfully.")]
    Delivered,

    [EnumMember(Value = "failed")]
    [Description("Paddle tried to deliver this notification, but all attempts failed. It's not scheduled to be retried.")]
    Failed
}