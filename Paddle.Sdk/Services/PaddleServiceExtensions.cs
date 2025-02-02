using Microsoft.Extensions.DependencyInjection;
using Paddle.Sdk.Config;

namespace Paddle.Sdk.Services;

public static class PaddleServiceExtensions {
    public static IServiceCollection AddPaddleClient(this IServiceCollection services, string apiKey, PaddleEnvironmentType environmentType) {
        services.AddHttpClient<IPaddle, Paddle>(client => new Paddle(apiKey, environmentType, client));
        return services;
    }
}