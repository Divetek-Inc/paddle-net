using System.Text.Json.Serialization;
using Paddle.Sdk.Entities.Shared;

namespace Paddle.Sdk.Entities.Events;

public class Event {
    [JsonPropertyName("event_id")]
    public string EventId { get; set; } = null!;

    [JsonPropertyName("event_type")]
    public EventType EventType { get; set; }

    [JsonPropertyName("occurred_at")]
    public DateTimeOffset OccurredAt { get; set; }

    [JsonPropertyName("notification_id")]
    public string NotificationId { get; set; } = null!;

    public object Data { get; set; } = null!;
}