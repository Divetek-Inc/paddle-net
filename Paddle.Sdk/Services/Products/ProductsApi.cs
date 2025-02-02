using System.Text.Json;
using Microsoft.AspNetCore.WebUtilities;
using Paddle.Sdk.Dto.Products;
using Paddle.Sdk.Dto.Products.Create;
using Paddle.Sdk.Dto.Shared;

namespace Paddle.Sdk.Services.Products;

public class ProductsApi(HttpClient httpClient, JsonSerializerOptions jsonOptions) : PaddleApiBase(httpClient, jsonOptions), IProductsApi {
    public override string BasePath => "/products";


    public async Task<ProductResponse?> CreateAsync(ProductCreateRequest request, CancellationToken cancellationToken = default) {
        return await PostAsync<ProductResponse>(BasePath, request, cancellationToken);
    }

    public async Task<ProductResponse?> GetAsync(string productId, Dictionary<string, string>? queryParams, CancellationToken cancellationToken = default) {
        string url = queryParams != null ? QueryHelpers.AddQueryString($"{BasePath}/{productId}", queryParams!) : $"{BasePath}/{productId}";
        return await base.GetAsync<ProductResponse>(url, cancellationToken);
    }

    public async Task<ProductListResponse?> ListAsync(Dictionary<string, string> queryParams, CancellationToken cancellationToken = default) {
        string url = QueryHelpers.AddQueryString(BasePath, queryParams!);
        return await base.GetAsync<ProductListResponse?>(url, cancellationToken);
    }

    public async Task<ProductResponse?> UpdateAsync(string productId, ProductBase request, CancellationToken cancellationToken = default) {
        string url = $"{BasePath}/{productId}";
        return await PutAsync<ProductResponse?>(url, request, cancellationToken);
    }
}