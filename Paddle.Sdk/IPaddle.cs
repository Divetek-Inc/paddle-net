using Paddle.Sdk.Api.Products;

namespace Paddle.Sdk;

public interface IPaddle {
    IProductsApi Products { get; }
}