namespace Paddle.Sdk.Dto.Shared.EnumParsers;

public static class EnumParserExtensions {
    public static string ToEnumString<T>(this T value) where T : Enum
        => PaddleEnumParser<T>.ToEnumString(value);

    public static T FromString<T>(this string value) where T : Enum
        => PaddleEnumParser<T>.FromString(value);

    public static string GetDescription<T>(this T value) where T : Enum
        => PaddleEnumParser<T>.GetDescription(value);
}