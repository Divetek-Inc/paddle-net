using System.Text.Json;
using Microsoft.Extensions.Logging;
using Paddle.Sdk.Dto.Products;

namespace Paddle.Sdk.Api.Products;

public class ProductsApi(
    HttpClient httpClient,
    JsonSerializerOptions jsonOptions,
    ILogger? logger = null
) : PaddleApi<ProductResponse, ProductListResponse, ProductCreate, ProductUpdate>(httpClient, jsonOptions, logger),
    IProductsApi {
    protected override string BasePath => "/products";
}