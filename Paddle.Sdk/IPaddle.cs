using Paddle.Sdk.Api.Addresses;
using Paddle.Sdk.Api.Customers;
using Paddle.Sdk.Api.Prices;
using Paddle.Sdk.Api.Products;

namespace Paddle.Sdk;

public interface IPaddle {
    IProductsApi Products { get; }

    IAddressApi Addresses { get; }

    ICustomersApi Customers { get; }

    IPricesApi Prices { get; }
}