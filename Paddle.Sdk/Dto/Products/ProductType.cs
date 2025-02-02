using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Paddle.Sdk.Json.Converters;

namespace Paddle.Sdk.Dto.Products;

[JsonConverter(typeof(PaddleJsonConverter<ProductType>))]
public enum ProductType {
    [EnumMember(Value = "custom")]
    [Description("Non-catalog item. Typically created for a specific transaction or subscription. Not returned when listing or shown in the Paddle dashboard.")]
    Custom,

    [EnumMember(Value = "standard")]
    [Description("Standard item. Can be considered part of your catalog and reused across transactions and subscriptions easily.")]
    Standard,
}