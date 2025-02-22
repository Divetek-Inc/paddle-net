namespace Paddle.Sdk.Entities.Transactions.Payments;

public class PaymentMethodDetails {
    
    public required PaymentMethodType Type { get; set; }

    public CardDetails? Card { get; set; }
}