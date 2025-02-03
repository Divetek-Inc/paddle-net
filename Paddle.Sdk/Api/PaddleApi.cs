using System.Text.Json;
using Microsoft.AspNetCore.WebUtilities;

namespace Paddle.Sdk.Api;

public abstract class PaddleApi<TResponse, TListResponse, TCreate, TUpdate>(
    HttpClient httpClient,
    JsonSerializerOptions jsonOptions
) : ApiBase(httpClient, jsonOptions),
    IPaddleApi<TResponse, TListResponse, TCreate, TUpdate> {
    protected abstract override string BasePath { get; }

    public virtual async Task<TResponse?> CreateAsync(TCreate request, CancellationToken cancellationToken = default) {
        return await PostAsync<TResponse>(BasePath, request, cancellationToken);
    }

    public virtual async Task<TResponse?> GetAsync(string id, Dictionary<string, string>? queryParams, CancellationToken cancellationToken = default) {
        string baseUrl = $"{BasePath}/{id}";
        string url = queryParams != null ? QueryHelpers.AddQueryString(baseUrl, queryParams!) : baseUrl;
        return await base.GetAsync<TResponse>(url, cancellationToken);
    }

    public virtual async Task<TListResponse?> ListAsync(Dictionary<string, string> queryParams, CancellationToken cancellationToken = default) {
        string url = QueryHelpers.AddQueryString(BasePath, queryParams!);
        return await base.GetAsync<TListResponse>(url, cancellationToken);
    }

    public virtual async Task<TResponse?> UpdateAsync(string id, TUpdate request, CancellationToken cancellationToken = default) {
        string url = $"{BasePath}/{id}";
        return await PutAsync<TResponse>(url, request, cancellationToken);
    }
}