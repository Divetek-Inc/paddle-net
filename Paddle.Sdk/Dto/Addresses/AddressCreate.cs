using Paddle.Sdk.Entities.Addresses;
using Paddle.Sdk.Entities.Shared;

namespace Paddle.Sdk.Dto.Addresses;

public class AddressCreate : AddressBase {
    public override required CountryCode CountryCode { get; set; }
}