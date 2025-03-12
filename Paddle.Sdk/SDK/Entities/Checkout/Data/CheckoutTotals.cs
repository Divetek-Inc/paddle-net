namespace Paddle.Sdk.SDK.Entities.Checkout.Data;

public class CheckoutTotals
{
    public required decimal Subtotal { get; set; }
    public required decimal Tax { get; set; }
    public required decimal Total { get; set; }
    public required decimal Discount { get; set; }
    public required decimal Credit { get; set; }
    public required decimal Balance { get; set; }
}