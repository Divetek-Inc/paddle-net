using Paddle.Sdk.Json.Converters;

namespace Paddle.Sdk.Dto.Prices;

using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[JsonConverter(typeof(PaddleJsonConverter<CurrencyCode>))]
public enum CurrencyCode {
    [EnumMember(Value = "USD")]
    [Description("United States Dollar")]
    USD,

    [EnumMember(Value = "EUR")]
    [Description("Euro")]
    EUR,

    [EnumMember(Value = "GBP")]
    [Description("Pound Sterling")]
    GBP,

    [EnumMember(Value = "JPY")]
    [Description("Japanese Yen")]
    JPY,

    [EnumMember(Value = "AUD")]
    [Description("Australian Dollar")]
    AUD,

    [EnumMember(Value = "CAD")]
    [Description("Canadian Dollar")]
    CAD,

    [EnumMember(Value = "CHF")]
    [Description("Swiss Franc")]
    CHF,

    [EnumMember(Value = "HKD")]
    [Description("Hong Kong Dollar")]
    HKD,

    [EnumMember(Value = "SGD")]
    [Description("Singapore Dollar")]
    SGD,

    [EnumMember(Value = "SEK")]
    [Description("Swedish Krona")]
    SEK,

    [EnumMember(Value = "ARS")]
    [Description("Argentine Peso")]
    ARS,

    [EnumMember(Value = "BRL")]
    [Description("Brazilian Real")]
    BRL,

    [EnumMember(Value = "CNY")]
    [Description("Chinese Yuan")]
    CNY,

    [EnumMember(Value = "COP")]
    [Description("Colombian Peso")]
    COP,

    [EnumMember(Value = "CZK")]
    [Description("Czech Koruna")]
    CZK,

    [EnumMember(Value = "DKK")]
    [Description("Danish Krone")]
    DKK,

    [EnumMember(Value = "HUF")]
    [Description("Hungarian Forint")]
    HUF,

    [EnumMember(Value = "ILS")]
    [Description("Israeli Shekel")]
    ILS,

    [EnumMember(Value = "INR")]
    [Description("Indian Rupee")]
    INR,

    [EnumMember(Value = "KRW")]
    [Description("South Korean Won")]
    KRW,

    [EnumMember(Value = "MXN")]
    [Description("Mexican Peso")]
    MXN,

    [EnumMember(Value = "NOK")]
    [Description("Norwegian Krone")]
    NOK,

    [EnumMember(Value = "NZD")]
    [Description("New Zealand Dollar")]
    NZD,

    [EnumMember(Value = "PLN")]
    [Description("Polish Zloty")]
    PLN,

    [EnumMember(Value = "RUB")]
    [Description("Russian Ruble")]
    RUB,

    [EnumMember(Value = "THB")]
    [Description("Thai Baht")]
    THB,

    [EnumMember(Value = "TRY")]
    [Description("Turkish Lira")]
    TRY,

    [EnumMember(Value = "TWD")]
    [Description("New Taiwan Dollar")]
    TWD,

    [EnumMember(Value = "UAH")]
    [Description("Ukrainian Hryvnia")]
    UAH,

    [EnumMember(Value = "VND")]
    [Description("Vietnamese Dong")]
    VND,

    [EnumMember(Value = "ZAR")]
    [Description("South African Rand")]
    ZAR
}