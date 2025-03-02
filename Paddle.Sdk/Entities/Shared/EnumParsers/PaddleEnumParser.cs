using System.ComponentModel;
using System.Reflection;
using System.Runtime.Serialization;

namespace Paddle.Sdk.Entities.Shared.EnumParsers;

public static class PaddleEnumParser<T> where T : Enum {
    public static string ToEnumString(T value) {
        Type enumType = typeof(T);
        MemberInfo[] memberInfo = enumType.GetMember(value.ToString());
        MemberInfo? enumValueMemberInfo = memberInfo.FirstOrDefault(m => m.DeclaringType == enumType);
        object[] valueAttributes = enumValueMemberInfo?.GetCustomAttributes(typeof(EnumMemberAttribute), false)
                                   ?? [];
        EnumMemberAttribute? enumMemberAttribute = (EnumMemberAttribute?)valueAttributes.FirstOrDefault();

        return enumMemberAttribute?.Value ?? value.ToString();
    }

    public static T FromString(string? value) {
        if (string.IsNullOrEmpty(value)) throw new ArgumentException("Value cannot be null or empty", nameof(value));

        Type enumType = typeof(T);
        
        // Try to find exact EnumMember match first
        foreach (FieldInfo field in enumType.GetFields()) {
            if (Attribute.GetCustomAttribute(field, typeof(EnumMemberAttribute)) is not EnumMemberAttribute attribute) continue;

            if (attribute.Value?.Equals(value, StringComparison.OrdinalIgnoreCase) == true) 
                return (T)(field.GetValue(null) ?? throw new InvalidOperationException($"Could not get enum value for {value}"));
        }

        // If no EnumMember match found, try parsing the enum value directly
        if (Enum.TryParse(enumType, value, true, out object? result))
        {
            return (T)result;
        }

        // Try to match by name (case-insensitive)
        foreach (string name in Enum.GetNames(enumType)) {
            if (name.Equals(value, StringComparison.OrdinalIgnoreCase)) {
                return (T)Enum.Parse(enumType, name);
            }
        }

        throw new ArgumentException($"'{value}' is not a valid value for enum {typeof(T).Name}");
    }

    public static string GetDescription(T value) {
        Type enumType = typeof(T);
        MemberInfo[] memberInfo = enumType.GetMember(value.ToString());
        MemberInfo? enumValueMemberInfo = memberInfo.FirstOrDefault(m => m.DeclaringType == enumType);
        object[]? valueAttributes = enumValueMemberInfo?.GetCustomAttributes(typeof(DescriptionAttribute), false);
        DescriptionAttribute? description = (DescriptionAttribute?)valueAttributes?.FirstOrDefault();

        return description?.Description ?? value.ToString();
    }
}