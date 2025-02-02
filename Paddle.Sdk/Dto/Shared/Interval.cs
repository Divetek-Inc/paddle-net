using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Paddle.Sdk.Dto.Shared.EnumParsers;

namespace Paddle.Sdk.Dto.Shared;

[JsonConverter(typeof(PaddleEnumParser<Interval>))]
public enum Interval {
    [EnumMember(Value = "day")]
    Day,

    [EnumMember(Value = "week")]
    Week,

    [EnumMember(Value = "month")]
    Month,

    [EnumMember(Value = "year")]
    Year
}