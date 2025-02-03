#region Products

global using ProductResponse = Paddle.Sdk.Entities.Shared.PaddleResponse<Paddle.Sdk.Entities.Products.Product>;
global using ProductListResponse = Paddle.Sdk.Entities.Shared.PaddleResponse<System.Collections.Generic.List<Paddle.Sdk.Entities.Products.Product>>;

#endregion

#region Prices

global using PriceResponse = Paddle.Sdk.Entities.Shared.PaddleResponse<Paddle.Sdk.Entities.Prices.Price>;
global using PriceListResponse = Paddle.Sdk.Entities.Shared.PaddleResponse<System.Collections.Generic.List<Paddle.Sdk.Entities.Prices.Price>>;

#endregion

#region Customers

global using CustomerResponse = Paddle.Sdk.Entities.Shared.PaddleResponse<Paddle.Sdk.Entities.Customers.Customer>;
global using CustomerListResponse = Paddle.Sdk.Entities.Shared.PaddleResponse<System.Collections.Generic.List<Paddle.Sdk.Entities.Customers.Customer>>;
global using CustomerAuthTokenResponse = Paddle.Sdk.Entities.Shared.PaddleResponse<Paddle.Sdk.Entities.Customers.CustomerAuthToken>;

#endregion

#region Addresses

global using AddressResponse = Paddle.Sdk.Entities.Shared.PaddleResponse<Paddle.Sdk.Entities.Addresses.Address>;
global using AddressListResponse = Paddle.Sdk.Entities.Shared.PaddleResponse<System.Collections.Generic.List<Paddle.Sdk.Entities.Addresses.Address>>;

#endregion