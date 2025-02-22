using Paddle.ApiTest;
using Paddle.Sdk;
using Paddle.Sdk.Dto.Customers;
using Paddle.Sdk.Entities.Customers;
using Paddle.Sdk.Entities.Shared;
using Paddle.Sdk.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddPaddleClient(options => {
    options.ApiKey = "YOUR_API_KEY";
    options.Environment = PaddleEnvironment.Sandbox; // or PaddleEnvironment.Production
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.MapOpenApi();
}

app.UseHttpsRedirection();

var summaries = new[] {
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () => {
        var forecast = Enumerable.Range(1, 5).Select(index =>
                new WeatherForecast
                (
                    DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    Random.Shared.Next(-20, 55),
                    summaries[Random.Shared.Next(summaries.Length)]
                ))
            .ToArray();
        return forecast;
    })
    .WithName("GetWeatherForecast");

app.Run();

namespace Paddle.ApiTest {
    record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary) {
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}