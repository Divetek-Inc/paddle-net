using Paddle.Sdk.Dto.Customers;

namespace Paddle.Sdk.Api.Customers;

public interface ICustomersApi : IPaddleApi<CustomerResponse, CustomerListResponse, CustomerCreate, CustomerUpdate> {
    Task<CustomerAuthTokenResponse?> GenerateAuthToken(string id, CancellationToken cancellationToken = default);
}