#region Products

global using ProductResponse = Paddle.Sdk.Entities.Shared.PaddleResponse<Paddle.Sdk.Entities.Products.PaddleProduct>;
global using ProductListResponse = Paddle.Sdk.Entities.Shared.PaddleResponse<System.Collections.Generic.List<Paddle.Sdk.Entities.Products.PaddleProduct>>;

#endregion

#region Prices

global using PriceResponse = Paddle.Sdk.Entities.Shared.PaddleResponse<Paddle.Sdk.Entities.Prices.PaddlePrice>;
global using PriceListResponse = Paddle.Sdk.Entities.Shared.PaddleResponse<System.Collections.Generic.List<Paddle.Sdk.Entities.Prices.PaddlePrice>>;

#endregion

#region Customers

global using CustomerResponse = Paddle.Sdk.Entities.Shared.PaddleResponse<Paddle.Sdk.Entities.Customers.PaddleCustomer>;
global using CustomerListResponse = Paddle.Sdk.Entities.Shared.PaddleResponse<System.Collections.Generic.List<Paddle.Sdk.Entities.Customers.PaddleCustomer>>;
global using CustomerAuthTokenResponse = Paddle.Sdk.Entities.Shared.PaddleResponse<Paddle.Sdk.Entities.Customers.CustomerAuthToken>;
global using CustomerSavedPaymentMethodsResponse = Paddle.Sdk.Entities.Shared.PaddleResponse<System.Collections.Generic.List<Paddle.Sdk.Entities.PaymentMethods.PaddlePaymentMethod>>;
global using CustomerPaymentMethodResponse = Paddle.Sdk.Entities.Shared.PaddleResponse<System.Collections.Generic.List<Paddle.Sdk.Entities.PaymentMethods.PaddlePaymentMethod>>;
global using CustomerPortalSessionResponse = Paddle.Sdk.Entities.Shared.PaddleResponse<Paddle.Sdk.Entities.Customers.CustomerPortalSession>;
global using BusinessResponse = Paddle.Sdk.Entities.Shared.PaddleResponse<Paddle.Sdk.Entities.Businesses.PaddleBusiness>;
global using BusinessListResponse = Paddle.Sdk.Entities.Shared.PaddleResponse<System.Collections.Generic.List<Paddle.Sdk.Entities.Businesses.PaddleBusiness>>;

#endregion

#region Addresses

global using AddressResponse = Paddle.Sdk.Entities.Shared.PaddleResponse<Paddle.Sdk.Entities.Addresses.PaddleAddress>;
global using AddressListResponse = Paddle.Sdk.Entities.Shared.PaddleResponse<System.Collections.Generic.List<Paddle.Sdk.Entities.Addresses.PaddleAddress>>;

#endregion

#region Subscriptions

global using SubscriptionResponse = Paddle.Sdk.Entities.Shared.PaddleResponse<Paddle.Sdk.Entities.Subscriptions.PaddleSubscription>;
global using SubscriptionListResponse = Paddle.Sdk.Entities.Shared.PaddleResponse<System.Collections.Generic.List<Paddle.Sdk.Entities.Subscriptions.PaddleSubscription>>;

#endregion

#region Transactions

global using TransactionListResponse = Paddle.Sdk.Entities.Shared.PaddleResponse<System.Collections.Generic.List<Paddle.Sdk.Entities.Transactions.PaddleTransaction>>;
global using InvoiceUrlResponse = Paddle.Sdk.Entities.Shared.PaddleResponse<Paddle.Sdk.Dto.Transactions.InvoiceUrl>;

#endregion