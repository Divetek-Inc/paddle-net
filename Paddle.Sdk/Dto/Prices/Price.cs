using Paddle.Sdk.Dto.Shared.Values;

namespace Paddle.Sdk.Dto.Prices;

public class Price : PriceBase {
    public string Id { get; set; }

    public Status Status { get; set; }
    
    
}