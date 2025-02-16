namespace Paddle.Sdk.Entities.Shared;

public class BillingCycle {
    public required int Frequency { get; set; }

    public required Interval Interval { get; set; }
}