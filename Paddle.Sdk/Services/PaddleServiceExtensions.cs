using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Paddle.Sdk.Config;

namespace Paddle.Sdk.Services;

public static class PaddleServiceExtensions {
    public static IServiceCollection AddPaddleClient(this IServiceCollection services, Action<PaddleOptions> configureOptions) {
        services.Configure(configureOptions);

        services.AddHttpClient<IPaddle, Paddle>((client, serviceProvider) => {
            PaddleOptions options = serviceProvider.GetRequiredService<IOptions<PaddleOptions>>().Value;
            return new Paddle(options.ApiKey, options.Environment, client);
        });

        return services;
    }
}