namespace Paddle.Sdk.Api.Notifications;

public interface INotificationsApi {
    Task<NotificationResponse?> GetAsync(string id, CancellationToken cancellationToken = default);
    Task<NotificationListResponse?> ListAsync(Dictionary<string, string>? queryParams, CancellationToken cancellationToken = default);
    Task<NotificationReplayResponse?> ReplayAsync(string id, CancellationToken cancellationToken = default);
}