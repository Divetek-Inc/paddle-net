using Paddle.Sdk.Entities.Customers;
using Paddle.Sdk.Entities.Shared.Values;

namespace Paddle.Sdk.Dto.Customers;

public class CustomerUpdate : CustomerBase {
    public Status Status { get; set; }
}