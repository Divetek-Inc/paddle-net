using Paddle.Sdk.Dto.Subscriptions;
using Paddle.Sdk.Entities.Subscriptions;

namespace Paddle.Sdk.Api.Subscriptions;

public interface ISubscriptionsApi {
    Task<SubscriptionResponse?> GetAsync(string id, Dictionary<string, string> queryParams, CancellationToken cancellationToken = default);

    Task<SubscriptionListResponse?> ListAsync(Dictionary<string, string> queryParams, CancellationToken cancellationToken = default);

    Task<SubscriptionResponse?> UpdateAsync(string id, SubscriptionUpdate request, CancellationToken cancellationToken = default);

    Task<SubscriptionResponse?> CancelAsync(string id, SubscriptionCancel request, CancellationToken cancellationToken = default);

    Task<SubscriptionResponse?> PauseAsync(string id, SubscriptionPause request, CancellationToken cancellationToken = default);

    Task<SubscriptionResponse?> ResumeAsync(string id, SubscriptionResume request, CancellationToken cancellationToken = default);
}