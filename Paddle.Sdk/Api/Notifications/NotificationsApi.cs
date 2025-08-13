using System.Text.Json;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;

namespace Paddle.Sdk.Api.Notifications;

public class NotificationsApi(HttpClient httpClient, JsonSerializerOptions jsonOptions, ILogger? logger = null) : ApiBase(httpClient, jsonOptions, logger), INotificationsApi {
    protected override string BasePath => "/notifications";

    public async Task<NotificationResponse?> GetAsync(string id, CancellationToken cancellationToken = default) {
        string url = $"{BasePath}/{id}";
        return await GetAsync<NotificationResponse>(url, cancellationToken);
    }

    public async Task<NotificationListResponse?> ListAsync(Dictionary<string, string>? queryParams, CancellationToken cancellationToken = default) {
        string baseUrl = $"{BasePath}";
        string url = queryParams != null ? QueryHelpers.AddQueryString(baseUrl, queryParams!) : baseUrl;
        return await GetAsync<NotificationListResponse>(url, cancellationToken);
    }

    public async Task<NotificationReplayResponse?> ReplayAsync(string id, CancellationToken cancellationToken = default) {
        string url = $"{BasePath}/{id}/replay";
        return await PostAsync<NotificationReplayResponse>(url, null, cancellationToken);
    }
}