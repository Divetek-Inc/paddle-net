using System.Text.Json;
using Microsoft.Extensions.Logging;
using Paddle.Sdk.Dto.Prices;

namespace Paddle.Sdk.Api.Prices;

public class PricesApi(
    HttpClient httpClient,
    JsonSerializerOptions jsonOptions,
    ILogger? logger = null
) : PaddleApi<PriceResponse, PriceListResponse, PriceCreate, PriceUpdate>(httpClient, jsonOptions, logger),
    IPricesApi {
    protected override string BasePath => "/prices";
}