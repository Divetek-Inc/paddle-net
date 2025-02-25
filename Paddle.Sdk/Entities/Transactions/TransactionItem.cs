using Paddle.Sdk.Entities.Prices;

namespace Paddle.Sdk.Entities.Transactions;

public class TransactionItem {
    public PaddlePrice Price { get; set; }

    public int Quantity { get; set; }

    public Proration? Proration { get; set; }
}