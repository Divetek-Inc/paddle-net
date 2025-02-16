using System.Text.Json.Serialization;
using Paddle.Sdk.Entities.Shared;
using Paddle.Sdk.Json.Converters;

namespace Paddle.Sdk.Entities.Events;

[JsonConverter(typeof(PaddleEventConverter))]
public abstract class Event
{
    [JsonPropertyName("event_id")]
    public string EventId { get; set; } = null!;

    [JsonPropertyName("event_type")]
    public EventType EventType { get; set; }

    [JsonPropertyName("occurred_at")]
    public DateTimeOffset OccurredAt { get; set; }

    [JsonPropertyName("notification_id")]
    public string NotificationId { get; set; } = null!;
}

public class Event<T> : Event
{
    [JsonPropertyName("data")]
    public T Data { get; set; } = default!;
}
