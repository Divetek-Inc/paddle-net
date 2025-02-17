using System.Text.Json;
using Microsoft.AspNetCore.WebUtilities;

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
}