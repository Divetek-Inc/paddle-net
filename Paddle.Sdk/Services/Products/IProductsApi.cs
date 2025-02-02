using Paddle.Sdk.Dto.Products;
using Paddle.Sdk.Dto.Products.Create;

namespace Paddle.Sdk.Services.Products;

public interface IProductsApi {
    Task<ProductResponse?> CreateAsync(ProductCreateRequest request, CancellationToken cancellationToken = default);

    Task<ProductResponse?> GetAsync(string productId, Dictionary<string, string> queryParams, CancellationToken cancellationToken = default);

    Task<ProductListResponse?> ListAsync(Dictionary<string, string> queryParams, CancellationToken cancellationToken = default);

    Task<ProductResponse?> UpdateAsync(string productId, ProductBase request, CancellationToken cancellationToken = default);
}