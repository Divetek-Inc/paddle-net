namespace Paddle.Sdk.SDK.Entities.Checkout.Data;

public class CheckoutCustomer {
    public required string Id { get; set; }
    public required string Email { get; set; }
    public required CheckoutAddress Address { get; set; }
    public CheckoutBusiness? Business { get; set; }
}