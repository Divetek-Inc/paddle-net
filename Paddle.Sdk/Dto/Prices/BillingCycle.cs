using System.Text.Json.Serialization;
using Paddle.Sdk.Dto.Shared;

namespace Paddle.Sdk.Dto.Prices;

public class BillingCycle {
    public required int Frequency { get; set; }

    public required Interval Interval { get; set; }
}