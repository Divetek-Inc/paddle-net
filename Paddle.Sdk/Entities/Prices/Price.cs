using Paddle.Sdk.Entities.Shared.Values;

namespace Paddle.Sdk.Entities.Prices;

public class Price : PriceBase {
    public string Id { get; set; }

    public Status Status { get; set; }
}