using System.Text.Json;
using Paddle.Sdk.Dto.Prices;

namespace Paddle.Sdk.Api.Prices;

public class PricesApi(
    HttpClient httpClient,
    JsonSerializerOptions jsonOptions
) : PaddleApi<PriceResponse, PriceListResponse, PriceCreate, PriceUpdate>(httpClient, jsonOptions),
    IPricesApi {
    protected override string BasePath => "/prices";
}