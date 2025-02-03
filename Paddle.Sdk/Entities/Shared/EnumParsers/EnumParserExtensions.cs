namespace Paddle.Sdk.Entities.Shared.EnumParsers;

public static class EnumParserExtensions {
    public static string ToEnumString<T>(this T value) where T : Enum {
        return PaddleEnumParser<T>.ToEnumString(value);
    }

    public static T FromString<T>(this string value) where T : Enum {
        return PaddleEnumParser<T>.FromString(value);
    }

    public static string GetDescription<T>(this T value) where T : Enum {
        return PaddleEnumParser<T>.GetDescription(value);
    }
}