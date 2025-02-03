using System.Text.Json;
using Microsoft.AspNetCore.WebUtilities;
using Paddle.Sdk.Dto.Addresses;
using Paddle.Sdk.Entities.Shared.Values;

namespace Paddle.Sdk.Api.Addresses;

public class AddressApi(
    HttpClient httpClient,
    JsonSerializerOptions jsonOptions
) : ApiBase(httpClient, jsonOptions), IAddressApi {
    protected override string BasePath => "/customers";

    public async Task<AddressResponse?> GetAsync(string customerId, string addressId, CancellationToken cancellationToken = default) {
        string url = $"{BasePath}/{customerId}/addresses/{addressId}";
        return await GetAsync<AddressResponse>(url, cancellationToken);
    }

    public async Task<AddressListResponse?> ListAsync(string customerId, Dictionary<string, string>? queryParams, CancellationToken cancellationToken = default) {
        string baseUrl = $"{BasePath}/{customerId}/addresses";
        string url = queryParams != null ? QueryHelpers.AddQueryString(baseUrl, queryParams!) : baseUrl;
        return await GetAsync<AddressListResponse>(url, cancellationToken);
    }

    public async Task<AddressResponse?> CreateAsync(string customerId, AddressCreate request, CancellationToken cancellationToken = default) {
        string url = $"{BasePath}/{customerId}/addresses";
        return await PostAsync<AddressResponse>(url, request, cancellationToken);
    }

    public async Task<AddressResponse?> UpdateAsync(string customerId, string addressId, AddressUpdate request, CancellationToken cancellationToken = default) {
        string url = $"{BasePath}/{customerId}/addresses/{addressId}";
        return await PutAsync<AddressResponse>(url, request, cancellationToken);
    }

    public async Task<AddressResponse?> ArchiveAsync(string customerId, string addressId, CancellationToken cancellationToken = default) {
        string url = $"{BasePath}/{customerId}/addresses/{addressId}";
        return await PutAsync<AddressResponse>(url, new AddressUpdate { Status = Status.Archived }, cancellationToken);
    }

    public async Task<AddressResponse?> ActivateAsync(string customerId, string addressId, CancellationToken cancellationToken = default) {
        string url = $"{BasePath}/{customerId}/addresses/{addressId}";
        return await PutAsync<AddressResponse>(url, new AddressUpdate { Status = Status.Active }, cancellationToken);
    }
}