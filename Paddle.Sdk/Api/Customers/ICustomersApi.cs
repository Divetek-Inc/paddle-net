using Paddle.Sdk.Dto.Customers;

namespace Paddle.Sdk.Api.Customers;

public interface ICustomersApi : IPaddleApi<CustomerResponse, CustomerListResponse, CustomerCreate, CustomerUpdate> {
    Task<CustomerAuthTokenResponse?> GenerateAuthToken(string id, CancellationToken cancellationToken = default);

    Task<CustomerSavedPaymentMethodsResponse?> GetSavedPaymentMethods(string customerId, CancellationToken cancellationToken = default);

    Task<CustomerPaymentMethodResponse?> GetPaymentMethod(string customerId, string paymentMethodId, CancellationToken cancellationToken = default);
    
    Task<bool> DeletePaymentMethod(string customerId, string paymentMethodId, CancellationToken cancellationToken = default);
}