using Paddle.Sdk.Dto.Addresses;

namespace Paddle.Sdk.Api.Addresses;

public interface IAddressApi {
    Task<AddressResponse?> GetAsync(string customerId, string addressId, CancellationToken cancellationToken = default);

    Task<AddressListResponse?> ListAsync(string customerId, Dictionary<string, string> queryParams, CancellationToken cancellationToken = default);

    new Task<AddressResponse?> CreateAsync(string customerId, AddressCreate request, CancellationToken cancellationToken = default);

    new Task<AddressResponse?> UpdateAsync(string customerId, string addressId, AddressUpdate request, CancellationToken cancellationToken = default);

    Task<AddressResponse?> ArchiveAsync(string customerId, string addressId, CancellationToken cancellationToken = default);

    Task<AddressResponse?> ActivateAsync(string customerId, string addressId, CancellationToken cancellationToken = default);
}