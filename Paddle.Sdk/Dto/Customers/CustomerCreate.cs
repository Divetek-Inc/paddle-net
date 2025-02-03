using Paddle.Sdk.Entities.Customers;

namespace Paddle.Sdk.Dto.Customers;

public class CustomerCreate : CustomerBase {
    public override required string Email { get; set; }
}