# Paddle .Net SDK

This is 👉 **Unofficial** Paddle SDK for .NET

> ‼️ *Paddle Billing API ONLY!*

SDK designed to provide a developer experience similar to
the [Paddle Node.js SDK](https://github.com/PaddleHQ/paddle-node-sdk)

## Implemented APIs

- [x] **Products**
- [x] **Prices**
- [x] **Customers**
- [x] **Customer Portal Sessions**
- [x] **Businesses**
- [x] **Addresses**
- [x] **Subscriptions**
- [x] **Transactions** (*no preview api yet*)
- [ ] **Notifications** (*in progress*)

## Requirements

- **.NET Version**: The SDK is built to support **.NET 9.0**.
- **Credentials**: Paddle `API key`.

## How to use

### Asp.Net Core

```csharp
// Add the Paddle to the services collection
builder.Services.AddPaddleClient(options => {
    options.ApiKey = "YOUR_API_KEY";
    options.Environment = PaddleEnvironment.Sandbox; // or PaddleEnvironment.Production
});


// Inject the client in your endpoint/controller
app.MapGet("/products", async (IPaddle paddle) => {
    var products = await paddle.Products.ListAsync();
    return products;
});
```

### .Net Core CLI

```csharp
// Initialize the Paddle client
var paddle = new Paddle(
   apiKey: "YOUR_API_KEY",
   environment: PaddleEnvironment.Sandbox // Or PaddleEnvironment.Production
);

// Example: Fetch and display product information
var products = await paddle.Products.ListAsync();

Console.WriteLine("Products:");
foreach (var product in products)
{
   Console.WriteLine($"ID: {product.Id}, Name: {product.Name}");
}

// Clean up the client (dispose resources)
paddle.Dispose();
```

## Installation

To include the Paddle SDK in your project, add a reference to the SDK package or include it directly in your solution.

1. Clone the repository or download it.
2. Build the SDK project if not already compiled.
3. Add a reference to the SDK DLL in your solution.

> Nuget package will be available soon

## Paddle API Reference

For detailed information about Paddle's API,
visit [Paddle API Documentation](https://developer.paddle.com/api-reference/overview)

## Contributing

Contributions to the Paddle SDK are welcome! If you encounter any issues or have ideas for improvements, feel free to
open an issue or submit a pull request.

### Steps to contribute:

1. Fork this repository.
2. Create a new branch for your feature/fix.
3. Commit your changes and push them to your branch.
4. Open a pull request for review.

## License

This SDK is licensed under the MIT License. See the See the [LICENSE.md](LICENSE.md) file for more details. file for
more details.

## Support

If you encounter any issues or require assistance, you can contact the repository maintainers or refer
to [Paddle API Documentation](https://developer.paddle.com/api-reference/overview) for additional guidance.