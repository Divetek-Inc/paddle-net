using System.Text.Json;
using Paddle.Sdk.Dto.Businesses;
using Paddle.Sdk.Dto.Customers;
using Microsoft.Extensions.Logging;

namespace Paddle.Sdk.Api.Customers;

public class CustomersApi(
    HttpClient httpClient,
    JsonSerializerOptions jsonOptions,
    ILogger? logger = null
) : PaddleApi<CustomerResponse, CustomerListResponse, CustomerCreate, CustomerUpdate>(httpClient, jsonOptions, logger),
    ICustomersApi {
    protected override string BasePath => "/customers";

    public async Task<CustomerAuthTokenResponse?> GenerateAuthToken(string id, CancellationToken cancellationToken = default) {
        string url = $"{BasePath}/{id}/auth-token";
        return await PostAsync<CustomerAuthTokenResponse>(url, null, cancellationToken);
    }

    public async Task<CustomerSavedPaymentMethodsResponse?> GetSavedPaymentMethods(string customerId, CancellationToken cancellationToken = default) {
        string url = $"{BasePath}/{customerId}/payment-methods";
        return await GetAsync<CustomerSavedPaymentMethodsResponse>(url, cancellationToken);
    }

    public async Task<CustomerPaymentMethodResponse?> GetPaymentMethod(string customerId, string paymentMethodId, CancellationToken cancellationToken = default) {
        string url = $"{BasePath}/{customerId}/payment-methods/{paymentMethodId}";
        return await GetAsync<CustomerPaymentMethodResponse>(url, cancellationToken);
    }

    public async Task<bool> DeletePaymentMethod(string customerId, string paymentMethodId, CancellationToken cancellationToken = default) {
        string url = $"{BasePath}/{customerId}/payment-methods/{paymentMethodId}";
        return await DeleteAsync(url, cancellationToken);
    }

    public async Task<CustomerPortalSessionResponse?> CreatePortalSession(string customerId, CancellationToken cancellationToken = default) {
        string url = $"{BasePath}/{customerId}/portal-session";
        return await PostAsync<CustomerPortalSessionResponse>(url, null, cancellationToken);
    }

    public async Task<BusinessResponse?> CreateBusiness(string customerId, BusinessCreate request, CancellationToken cancellationToken = default) {
        string url = $"{BasePath}/{customerId}/businesses";
        return await PostAsync<BusinessResponse>(url, request, cancellationToken);
    }

    public async Task<BusinessListResponse?> ListBusinesses(string customerId, CancellationToken cancellationToken = default) {
        string url = $"{BasePath}/{customerId}/businesses";
        return await GetAsync<BusinessListResponse>(url, cancellationToken);
    }

    public async Task<BusinessResponse?> GetBusiness(string customerId, string businessId, CancellationToken cancellationToken = default) {
        string url = $"{BasePath}/{customerId}/businesses/{businessId}";
        return await GetAsync<BusinessResponse>(url, cancellationToken);
    }

    public async Task<BusinessResponse?> UpdateBusiness(string customerId, string businessId, BusinessUpdate request, CancellationToken cancellationToken = default) {
        string url = $"{BasePath}/{customerId}/businesses/{businessId}";
        return await PutAsync<BusinessResponse>(url, request, cancellationToken);
    }
}