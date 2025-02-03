using Paddle.Sdk.Dto.Prices;

namespace Paddle.Sdk.Api.Prices;

public interface IPricesApi : IPaddleApi<PriceResponse, PriceListResponse, PriceCreate, PriceUpdate>;