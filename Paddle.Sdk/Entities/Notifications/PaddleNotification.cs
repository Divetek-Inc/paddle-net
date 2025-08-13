using System.Text.Json.Serialization;
using Paddle.Sdk.Entities.Addresses;
using Paddle.Sdk.Entities.Events;
using Paddle.Sdk.Entities.Shared;

namespace Paddle.Sdk.Entities.Notifications;

public class PaddleNotification {
    public required string Id { get; set; }

    public required NotificationType Type { get; set; }

    public required NotificationStatus Status { get; set; }

    public required NotificationPayload Payload { get; set; }

    [JsonPropertyName("occurred_at")]
    public DateTimeOffset OccurredAt { get; set; }

    [JsonPropertyName("delivered_at")]
    public DateTimeOffset? DeliveredAt { get; set; }

    [JsonPropertyName("replayed_at")]
    public DateTimeOffset? ReplayedAt { get; set; }

    public required string Origin { get; set; }

    [JsonPropertyName("last_attempt_at")]
    public DateTimeOffset? LastAttemptAt { get; set; }

    [JsonPropertyName("retry_at")]
    public DateTimeOffset? RetryAt { get; set; }

    [JsonPropertyName("times_attempted")]
    public int TimesAttempted { get; set; }

    [JsonPropertyName("notification_setting_id")]
    public required string NotificationSettingId { get; set; }
}

public class NotificationPayload {
    public required PaddleAddress Data { get; set; }

    [JsonPropertyName("event_id")]
    public required string EventId { get; set; }

    [JsonPropertyName("event_type")]
    public required EventType EventType { get; set; }

    [JsonPropertyName("occurred_at")]
    public DateTimeOffset OccurredAt { get; set; }

    [JsonPropertyName("notification_id")]
    public required string NotificationId { get; set; }
}