using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Paddle.Sdk.Json.Converters;

namespace Paddle.Sdk.Entities.Transactions.Payments;

[JsonConverter(typeof(PaddleJsonConverter<PaymentMethodType>))]
public enum PaymentMethodType
{
    [EnumMember(Value = "alipay")]
    [Description("Alipay, popular in China.")]
    Alipay,

    [EnumMember(Value = "apple_pay")]
    [Description("Apple Pay on a supported Apple device.")]
    ApplePay,

    [EnumMember(Value = "bancontact")]
    [Description("Bancontact, popular in Belgium.")]
    Bancontact,

    [EnumMember(Value = "card")]
    [Description("Credit or debit card.")]
    Card,

    [EnumMember(Value = "google_pay")]
    [Description("Google Pay on a supported Android device, Chromebook, or Google Chrome browser.")]
    GooglePay,

    [EnumMember(Value = "ideal")]
    [Description("iDEAL, popular in the Netherlands.")]
    Ideal,

    [EnumMember(Value = "offline")]
    [Description("Payment recorded offline.")]
    Offline,

    [EnumMember(Value = "paypal")]
    [Description("PayPal.")]
    Paypal,

    [EnumMember(Value = "unknown")]
    [Description("Payment method not known.")]
    Unknown,

    [EnumMember(Value = "wire_transfer")]
    [Description("Wire transfer, sometimes called bank transfer.")]
    WireTransfer
}
