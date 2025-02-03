using Paddle.Sdk.Entities.Prices;

namespace Paddle.Sdk.Dto.Prices;

public class PriceCreate : PriceBase {
    public override required string ProductId { get; set; }

    public override required string Description { get; set; }
}