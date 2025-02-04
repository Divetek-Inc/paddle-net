using System.Text.Json;
using Paddle.Sdk.Dto.Customers;

namespace Paddle.Sdk.Api.Customers;

public class CustomersApi(
    HttpClient httpClient,
    JsonSerializerOptions jsonOptions
) : PaddleApi<CustomerResponse, CustomerListResponse, CustomerCreate, CustomerUpdate>(httpClient, jsonOptions),
    ICustomersApi {
    protected override string BasePath => "/customers";

    public async Task<CustomerAuthTokenResponse?> GenerateAuthToken(string id, CancellationToken cancellationToken = default) {
        string url = $"{BasePath}/{id}/auth-token";
        return await PostAsync<CustomerAuthTokenResponse>(url, null, cancellationToken);
    }
}