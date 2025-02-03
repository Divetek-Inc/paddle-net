using Paddle.Sdk.Entities.Shared;

namespace Paddle.Sdk.Entities.Prices;

public class BillingCycle {
    public required int Frequency { get; set; }

    public required Interval Interval { get; set; }
}