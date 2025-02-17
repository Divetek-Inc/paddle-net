using System.Text.Json;
using Microsoft.AspNetCore.WebUtilities;
using Paddle.Sdk.Dto.Subscriptions;

namespace Paddle.Sdk.Api.Subscriptions;

public class SubscriptionsApi(
    HttpClient httpClient,
    JsonSerializerOptions jsonOptions
) : ApiBase(httpClient, jsonOptions), ISubscriptionsApi {
    protected override string BasePath => "/subscriptions";

    public async Task<SubscriptionResponse?> GetAsync(string id, Dictionary<string, string> queryParams, CancellationToken cancellationToken = default) {
        string url = $"{BasePath}/{id}";
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
}