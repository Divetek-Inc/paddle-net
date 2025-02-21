using Paddle.Sdk.Dto.Businesses;
using Paddle.Sdk.Dto.Customers;

namespace Paddle.Sdk.Api.Customers;

public interface ICustomersApi : IPaddleApi<CustomerResponse, CustomerListResponse, CustomerCreate, CustomerUpdate> {
    Task<CustomerAuthTokenResponse?> GenerateAuthToken(string id, CancellationToken cancellationToken = default);

    Task<CustomerSavedPaymentMethodsResponse?> GetSavedPaymentMethods(string customerId, CancellationToken cancellationToken = default);

    Task<CustomerPaymentMethodResponse?> GetPaymentMethod(string customerId, string paymentMethodId, CancellationToken cancellationToken = default);

    Task<bool> DeletePaymentMethod(string customerId, string paymentMethodId, CancellationToken cancellationToken = default);

    Task<CustomerPortalSessionResponse?> CreatePortalSession(string customerId, CancellationToken cancellationToken = default);

    Task<BusinessResponse?> CreateBusiness(string customerId, BusinessCreate request,CancellationToken cancellationToken = default);

    Task<BusinessListResponse?> ListBusinesses(string customerId, CancellationToken cancellationToken = default);

    Task<BusinessResponse?> GetBusiness(string customerId, string businessId, CancellationToken cancellationToken = default);

    Task<BusinessResponse?> UpdateBusiness(string customerId, string businessId, BusinessUpdate request, CancellationToken cancellationToken = default);
}