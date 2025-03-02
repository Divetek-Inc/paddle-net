using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Paddle.Sdk.Json.Converters;

namespace Paddle.Sdk.Entities.Shared;

[JsonConverter(typeof(PaddleJsonConverter<Interval>))]
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