using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Paddle.Sdk.Json.Converters;

namespace Paddle.Sdk.Entities.Transactions.Payments;

[JsonConverter(typeof(PaddleJsonConverter<CardType>))]
public enum CardType
{
    [EnumMember(Value = "american_express")]
    [Description("American Express")]
    AmericanExpress,

    [EnumMember(Value = "diners_club")]
    [Description("Diners Club")]
    DinersClub,

    [EnumMember(Value = "discover")]
    [Description("Discover Card")]
    Discover,

    [EnumMember(Value = "jcb")]
    [Description("JCB Card, popular in Japan")]
    Jcb,

    [EnumMember(Value = "mada")]
    [Description("Mada Card, popular in Saudi Arabia")]
    Mada,

    [EnumMember(Value = "maestro")]
    [Description("Maestro (debit card)")]
    Maestro,

    [EnumMember(Value = "mastercard")]
    [Description("Mastercard")]
    Mastercard,

    [EnumMember(Value = "union_pay")]
    [Description("UnionPay, popular in China")]
    UnionPay,

    [EnumMember(Value = "unknown")]
    [Description("Card type unknown")]
    Unknown,

    [EnumMember(Value = "visa")]
    [Description("Visa")]
    Visa
}
