namespace Paddle.Sdk.Entities.Customers;

public class CustomerBase : PaddleBaseEntity {
    public virtual string? Email { get; set; }

    public string? Name { get; set; }

    public string Locale { get; set; } = "en";
}