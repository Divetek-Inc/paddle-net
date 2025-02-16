using Paddle.Sdk.Entities.Shared;
using Paddle.Sdk.Entities.Subscriptions;

namespace Paddle.Sdk.Entities.Transactions;

public class Proration {
    public string Rate { get; set; }

    public BillingPeriod BillingPeriod { get; set; }
}