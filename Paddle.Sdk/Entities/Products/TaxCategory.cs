using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Paddle.Sdk.Json.Converters;

namespace Paddle.Sdk.Entities.Products;

[JsonConverter(typeof(PaddleJsonConverter<TaxCategory>))]
public enum TaxCategory {
    [EnumMember(Value = "digital-goods")]
    [Description("Non-customizable digital files or media (not software) acquired with an up front payment")]
    DigitalGoods,

    [EnumMember(Value = "ebooks")]
    [Description("Digital books and educational material which is sold with permanent rights for use by the customer")]
    Ebooks,

    [EnumMember(Value = "implementation-services")]
    [Description("Remote configuration, set-up, and integrating software on behalf of a customer")]
    ImplementationServices,

    [EnumMember(Value = "professional-services")]
    [Description("Services that involve the application of your expertise and specialized knowledge of a software product")]
    ProfessionalServices,

    [EnumMember(Value = "saas")]
    [Description("Products that allow users to connect to and use online or cloud-based applications over the Internet")]
    Saas,

    [EnumMember(Value = "software-programming-services")]
    [Description("Services that can be used to customize and white label software products")]
    SoftwareProgrammingServices,

    [EnumMember(Value = "standard")]
    [Description("Software products that are pre-written and can be downloaded and installed onto a local device")]
    Standard,

    [EnumMember(Value = "training-services")]
    [Description("Training and education services related to software products")]
    TrainingServices,

    [EnumMember(Value = "website-hosting")]
    [Description("Cloud storage service for personal or corporate information, assets, or data")]
    WebsiteHosting
}