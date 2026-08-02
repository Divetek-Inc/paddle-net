using System.Text.Json;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Paddle.Sdk.Dto.Subscriptions;
using Paddle.Sdk.Entities.Shared;
using Paddle.Sdk.Entities.Subscriptions;

namespace Paddle.Sdk.Api.Subscriptions;

public class SubscriptionsApi(
    HttpClient httpClient,
    JsonSerializerOptions jsonOptions,
    ILogger? logger = null
) : ApiBase(httpClient, jsonOptions, logger), ISubscriptionsApi {
    protected override string BasePath => "/subscriptions";

    public async Task<SubscriptionResponse?> GetAsync(string id, Dictionary<string, string> queryParams, CancellationToken cancellationToken = default) {
        string url = queryParams.Count == 0
            ? $"{BasePath}/{id}"
            : QueryHelpers.AddQueryString(
                $"{BasePath}/{id}",
                queryParams.ToDictionary(pair => pair.Key, pair => (string?)pair.Value)
            );
        return await GetAsync<SubscriptionResponse>(url, cancellationToken);
    }

    public async Task<SubscriptionListResponse?> ListAsync(Dictionary<string, string> queryParams, CancellationToken cancellationToken = default) {
        string url = QueryHelpers.AddQueryString(BasePath, queryParams!);
        return await GetAsync<SubscriptionListResponse>(url, cancellationToken);
    }

    public async Task<SubscriptionResponse?> UpdateAsync(string id, SubscriptionUpdate request, CancellationToken cancellationToken = default) {
        string url = $"{BasePath}/{id}";
        return await PatchAsync<SubscriptionResponse>(url, request, cancellationToken);
    }

    public async Task<SubscriptionResponse?> CancelAsync(string id, SubscriptionCancel request, CancellationToken cancellationToken = default) {
        string url = $"{BasePath}/{id}/cancel";
        return await PostAsync<SubscriptionResponse>(url, request, cancellationToken);
    }

    public async Task<SubscriptionResponse?> PauseAsync(string id, SubscriptionPause request, CancellationToken cancellationToken = default) {
        string url = $"{BasePath}/{id}/pause";
        return await PostAsync<SubscriptionResponse>(url, request, cancellationToken);
    }

    public async Task<SubscriptionResponse?> ResumeAsync(string id, SubscriptionResume request, CancellationToken cancellationToken = default) {
        string url = $"{BasePath}/{id}/resume";
        return await PostAsync<SubscriptionResponse>(url, request, cancellationToken);
    }

    public async Task<PaddleResponse<SubscriptionChargePreview>?> PreviewChargeAsync(
        string id,
        SubscriptionCharge request,
        CancellationToken cancellationToken = default
    ) {
        string url = $"{BasePath}/{id}/charge/preview";
        return await PostAsync<PaddleResponse<SubscriptionChargePreview>>(url, request, cancellationToken);
    }

    public async Task<SubscriptionResponse?> CreateChargeAsync(
        string id,
        SubscriptionCharge request,
        CancellationToken cancellationToken = default
    ) {
        string url = $"{BasePath}/{id}/charge";
        return await PostAsync<SubscriptionResponse>(url, request, cancellationToken);
    }
}
