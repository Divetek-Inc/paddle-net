using System.Text.Json.Serialization;

namespace Paddle.Sdk.Entities.Notifications;

public class PaddleNotificationSimple {
    [JsonPropertyName("notification_id")]
    public required string NotificationId { get; set; }
}