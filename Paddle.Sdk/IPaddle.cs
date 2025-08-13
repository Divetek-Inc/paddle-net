using Paddle.Sdk.Api.Addresses;
using Paddle.Sdk.Api.Customers;
using Paddle.Sdk.Api.Notifications;
using Paddle.Sdk.Api.Prices;
using Paddle.Sdk.Api.Products;
using Paddle.Sdk.Api.Subscriptions;
using Paddle.Sdk.Api.Transactions;

namespace Paddle.Sdk;

public interface IPaddle {
    IProductsApi Products { get; }

    IAddressApi Addresses { get; }

    ICustomersApi Customers { get; }

    ISubscriptionsApi Subscriptions { get; }

    ITransactionsApi Transactions { get; }

    IPricesApi Prices { get; }
    
    INotificationsApi Notifications { get; }

    T? Deserialize<T>(string json);

    string Serialize<T>(T obj);
}