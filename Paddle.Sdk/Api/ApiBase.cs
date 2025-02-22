using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using Paddle.Sdk.Http;

namespace Paddle.Sdk.Api;

public abstract class ApiBase(HttpClient httpClient, JsonSerializerOptions jsonOptions) {
    protected abstract string BasePath { get; }

    /// <exception cref="PaddleApiException">Thrown when api request failed</exception>
    protected async Task<T?> GetAsync<T>(string url, CancellationToken cancellationToken = default) {
        HttpResponseMessage response = await httpClient.GetAsync(url, cancellationToken);
        await EnsureSuccessAsync(response);
        return await response.Content.ReadFromJsonAsync<T>(jsonOptions, cancellationToken);
    }

    /// <exception cref="PaddleApiException">Thrown when api request failed</exception>
    protected async Task<T?> PostAsync<T>(string url, object? data, CancellationToken cancellationToken = default) {
        HttpResponseMessage response = await httpClient.PostAsJsonAsync(url, data, jsonOptions, cancellationToken);
        await EnsureSuccessAsync(response);
        return await response.Content.ReadFromJsonAsync<T>(jsonOptions, cancellationToken);
    }

    /// <exception cref="PaddleApiException">Thrown when api request failed</exception>
    protected async Task<T?> PutAsync<T>(string url, object data, CancellationToken cancellationToken = default) {
        HttpResponseMessage response = await httpClient.PutAsJsonAsync(url, data, jsonOptions, cancellationToken);
        await EnsureSuccessAsync(response);
        return await response.Content.ReadFromJsonAsync<T>(jsonOptions, cancellationToken);
    }

    /// <exception cref="PaddleApiException">Thrown when api request failed</exception>
    protected async Task<T?> PatchAsync<T>(string url, object data, CancellationToken cancellationToken = default) {
        HttpResponseMessage response = await httpClient.PatchAsJsonAsync(url, data, jsonOptions, cancellationToken);
        await EnsureSuccessAsync(response);
        return await response.Content.ReadFromJsonAsync<T>(jsonOptions, cancellationToken);
    }

    /// <exception cref="PaddleApiException">Thrown when api request failed</exception>
    protected async Task<bool> DeleteAsync(string url, CancellationToken cancellationToken = default) {
        HttpResponseMessage response = await httpClient.DeleteAsync(url, cancellationToken);
        return response.StatusCode == HttpStatusCode.NoContent;
    }

    private static async Task EnsureSuccessAsync(HttpResponseMessage response) {
        if (!response.IsSuccessStatusCode) {
            string error = await response.Content.ReadAsStringAsync();

            throw new PaddleApiException(
                $"The API request failed with status code: {response.StatusCode}. Response: {error}",
                response.StatusCode,
                error
            );
        }
    }
}