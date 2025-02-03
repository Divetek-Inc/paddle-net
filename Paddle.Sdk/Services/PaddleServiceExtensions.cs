using Microsoft.Extensions.DependencyInjection;

namespace Paddle.Sdk.Services;

public static class PaddleServiceExtensions {
    public static IServiceCollection AddPaddleClient(this IServiceCollection services, string apiKey, PaddleEnvironment environment) {
        services.AddHttpClient<IPaddle, Paddle>(client => new Paddle(apiKey, environment, client));
        return services;
    }
}