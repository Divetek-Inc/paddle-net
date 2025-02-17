namespace Paddle.Sdk.Api.Subscriptions;

public interface ISubscriptionsApi {
    Task<SubscriptionResponse?> GetAsync(string id, Dictionary<string, string> queryParams, CancellationToken cancellationToken = default);

    Task<SubscriptionListResponse?> ListAsync(Dictionary<string, string> queryParams, CancellationToken cancellationToken = default);
}