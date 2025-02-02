using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Paddle.Sdk.Json.Converters;

namespace Paddle.Sdk.Dto.Shared.Values;

[JsonConverter(typeof(PaddleJsonConverter<Status>))]
public enum Status {
    [EnumMember(Value = "active")]
    [Description("Entity is active and can be used.")]
    Active,

    [EnumMember(Value = "archived")]
    [Description("Entity is archived, so can't be used.")]
    Archived,
}