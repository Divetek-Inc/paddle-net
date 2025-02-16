using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Paddle.Sdk.Json.Converters;

namespace Paddle.Sdk.Entities.Shared;

[JsonConverter(typeof(PaddleJsonConverter<CollectingMode>))]
public enum CollectingMode 
{
    [EnumMember(Value = "automatic")]
    [Description("Payment is collected automatically using a checkout initially, then using a payment method on file.")]
    Automatic,

    [EnumMember(Value = "manual")]
    [Description("Payment is collected manually. Customers are sent an invoice with payment terms and can make a payment offline or using a checkout. Requires billing_details.")]
    Manual
}
