using Paddle.Sdk.Entities.Shared;

namespace Paddle.Sdk.Entities.Addresses;

public class Address : AddressBase {
    public override required CountryCode CountryCode { get; set; }
}