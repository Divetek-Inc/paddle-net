using System.Text.Json;

namespace Paddle.Sdk.Json;

public static class PaddleJson {
    public static JsonSerializerOptions Options = new() {
        PropertyNameCaseInsensitive = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
    };

    public static T Deserialize<T>(string json) {
        return JsonSerializer.Deserialize<T>(json, Options)!;
    }

    public static string Serialize<T>(T obj) {
        return JsonSerializer.Serialize(obj, Options);
    }
}