using Paddle.Sdk.Services.Products;

namespace Paddle.Sdk;

public interface IPaddle {
    IProductsApi Products { get; }
}