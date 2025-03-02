// See https://aka.ms/new-console-template for more information


using Microsoft.Extensions.Logging;
using Paddle.Sdk;
using Paddle.Sdk.Entities.Shared;
using Paddle.Sdk.Entities.Subscriptions;
using Paddle.Sdk.Entities.Transactions;

// Create logger factory and logger
using var loggerFactory = LoggerFactory.Create(builder => {
    builder
        .AddConsole()
        .SetMinimumLevel(LogLevel.Debug);
});

ILogger<Paddle.Sdk.Paddle> logger = loggerFactory.CreateLogger<Paddle.Sdk.Paddle>();

// Load .env file
DotNetEnv.Env.Load(Path.Combine(AppContext.BaseDirectory, ".env"));

string? apiKey = Environment.GetEnvironmentVariable("PADDLE_API_KEY");
if (string.IsNullOrEmpty(apiKey)) {
    throw new Exception("PADDLE_API_KEY environment variable is not set");
}

// Create Paddle instance with logger
Paddle.Sdk.Paddle paddle = new(
    apiKey: apiKey,
    environment: PaddleEnvironment.Sandbox,
    logger: logger
);

// Get Transaction
PaddleResponse<PaddleSubscription>? subscription = await paddle.Subscriptions.GetAsync("sub_01jn9t1b2tptna854hj87aejdr", []);
PaddleResponse<PaddleTransaction>? transaction = await paddle.Transactions.GetAsync("txn_01jn9sbgkhq1z45a5kj7byw8k1");
var test = 123;


Console.WriteLine("Hello, World!");