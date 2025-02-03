namespace Paddle.Sdk.Entities.Subscriptions;

public class SubscriptionBase : PaddleBaseEntity {
    public string CustomerId { get; set; }
    
    public string AddressId { get; set; }
}