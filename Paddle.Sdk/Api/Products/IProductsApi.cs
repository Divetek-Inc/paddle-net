using Paddle.Sdk.Dto.Products;

namespace Paddle.Sdk.Api.Products;

public interface IProductsApi : IPaddleApi<ProductResponse, ProductListResponse, ProductCreate, ProductUpdate>;