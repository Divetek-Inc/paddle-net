using System.Text.Json;
using System.Text.Json.Serialization;
using Paddle.Sdk.Dto.Shared.EnumParsers;
using Paddle.Sdk.Dto.Shared.Values;

namespace Paddle.Sdk.Json.Converters;

public class PaddleJsonConverter<T> : JsonConverter<T> where T : Enum {
    public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
        string? value = reader.GetString();
        return PaddleEnumParser<T>.FromString(value);
    }

    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options) {
        writer.WriteStringValue(PaddleEnumParser<T>.ToEnumString(value));
    }
}