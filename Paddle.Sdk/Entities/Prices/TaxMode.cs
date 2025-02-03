using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Paddle.Sdk.Json.Converters;

namespace Paddle.Sdk.Entities.Prices;

[JsonConverter(typeof(PaddleJsonConverter<TaxMode>))]
public enum TaxMode {
    [EnumMember(Value = "account_setting")]
    [Description("Prices use the setting from your account")]
    AccountSetting,

    [EnumMember(Value = "external")]
    [Description("Prices are exclusive of tax")]
    External,

    [EnumMember(Value = "internal")]
    [Description("Prices are inclusive of tax")]
    Internal
}