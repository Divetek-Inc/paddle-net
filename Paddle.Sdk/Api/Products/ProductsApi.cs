using System.Text.Json;
using Paddle.Sdk.Dto.Products;

namespace Paddle.Sdk.Api.Products;

public class ProductsApi(
    HttpClient httpClient,
    JsonSerializerOptions jsonOptions
) : PaddleApi<ProductResponse, ProductListResponse, ProductCreate, ProductUpdate>(httpClient, jsonOptions),
    IProductsApi {
    protected override string BasePath => "/products";
}