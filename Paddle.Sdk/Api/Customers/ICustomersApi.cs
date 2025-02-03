using Paddle.Sdk.Dto.Customers;
using Paddle.Sdk.Entities.Customers;
using Paddle.Sdk.Entities.Shared;

namespace Paddle.Sdk.Api.Customers;

public interface ICustomersApi : IPaddleApi<CustomerResponse, CustomerListResponse, CustomerCreate, CustomerUpdate> {
    Task<PaddleResponse<CustomerAuthToken>> GenerateAuthToken(string id, CancellationToken cancellationToken = default);
}