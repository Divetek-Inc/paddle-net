using Microsoft.AspNetCore.Http.HttpResults;
using Paddle.Sdk;
using Paddle.Sdk.Dto.Customers;
using Paddle.Sdk.Entities.Customers;
using Paddle.Sdk.Entities.Notifications;
using Paddle.Sdk.Entities.Shared;
using Paddle.Sdk.Entities.Subscriptions;
using Paddle.Sdk.Entities.Transactions;
using Paddle.Sdk.Services;

DotNetEnv.Env.Load();

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddPaddleClient(options => {
    options.ApiKey = Environment.GetEnvironmentVariable("PADDLE_API_KEY");
    options.Environment = PaddleEnvironment.Sandbox; // or PaddleEnvironment.Production
});


WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.MapOpenApi();
}

app.UseHttpsRedirection();

string[] summaries = new[] {
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/test", async (IPaddle paddle) => {
        PaddleResponse<PaddleSubscription>? subscription = await paddle.Subscriptions.GetAsync("sub_01jn9t1b2tptna854hj87aejdr", new Dictionary<string, string>());
        var test = 23;
    })
    .WithName("Test");

app.MapGet("/notify", async (HttpRequest request, IPaddle paddle, CancellationToken cancellationToken) => {
    // Convert query parameters to Dictionary<string, string>
    Dictionary<string, string>? queryParams = null;

    if (request.Query.Count != 0) {
        queryParams = request.Query.ToDictionary(
            kvp => kvp.Key,
            kvp => kvp.Value.ToString()
        );
    }

    PaddleResponse<List<PaddleNotification>>? notificationList = await paddle.Notifications.ListAsync(queryParams, cancellationToken: cancellationToken);

    return TypedResults.Ok(notificationList);
}).WithName("Notify");

app.MapGet("/transaction/{id}", async (string id, IPaddle paddle) => {
    PaddleResponse<PaddleTransaction>? transaction = await paddle.Transactions.GetAsync(id, new Dictionary<string, string>());
    return TypedResults.Ok(transaction);
});

app.Run();