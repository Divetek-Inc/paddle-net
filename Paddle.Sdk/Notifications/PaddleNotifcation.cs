using System.Text.Json.Serialization;

namespace Paddle.Sdk.Entities;

public class PaddleNotification {
    [JsonPropertyName("event_id")]
    public string EventId { get; set; } = null!;

    [JsonPropertyName("event_type")]
    public PaddleEvent EventType { get; set; }

    [JsonPropertyName("occurred_at")]
    public DateTimeOffset OccurredAt { get; set; }

    [JsonPropertyName("notification_id")]
    public string NotificationId { get; set; } = null!;

    public object Data { get; set; } = null!;
}