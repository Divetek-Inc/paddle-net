// See https://aka.ms/new-console-template for more information


using System.Text.Json;
using Microsoft.Extensions.Logging;
using Paddle.Sdk;
using Paddle.Sdk.Entities.Events;
using Paddle.Sdk.Entities.Shared;
using Paddle.Sdk.Entities.Subscriptions;
using Paddle.Sdk.Entities.Transactions;

// Create logger factory and logger
using var loggerFactory = LoggerFactory.Create(builder => {
    builder
        .AddConsole()
        .SetMinimumLevel(LogLevel.Debug);
});

ILogger<Paddle.Sdk.Paddle> logger = loggerFactory.CreateLogger<Paddle.Sdk.Paddle>();

// Load .env file
DotNetEnv.Env.Load(Path.Combine(AppContext.BaseDirectory, ".env"));

string? apiKey = Environment.GetEnvironmentVariable("PADDLE_API_KEY");
if (string.IsNullOrEmpty(apiKey)) {
    throw new Exception("PADDLE_API_KEY environment variable is not set");
}

var jsonStr =
    "{\"data\":{\"id\":\"txn_01jnbnf1y5fm6hhm0b5ee96dph\",\"items\":[{\"price\":{\"id\":\"pri_01jkvh46f2n46r065kr50zg7cn\",\"name\":\"Commercial License (monthly)\",\"type\":\"standard\",\"status\":\"active\",\"quantity\":{\"maximum\":999999,\"minimum\":1},\"tax_mode\":\"account_setting\",\"created_at\":\"2025-02-11T22:12:26.210363Z\",\"product_id\":\"pro_01j0vk6e4ka8kdt6ck8crpnpmc\",\"unit_price\":{\"amount\":\"800\",\"currency_code\":\"USD\"},\"updated_at\":\"2025-02-14T08:09:45.363012Z\",\"custom_data\":null,\"description\":\"Commercial License / MONTHLY\",\"trial_period\":null,\"billing_cycle\":{\"interval\":\"month\",\"frequency\":1},\"unit_price_overrides\":[]},\"price_id\":\"pri_01jkvh46f2n46r065kr50zg7cn\",\"quantity\":4,\"proration\":null}],\"origin\":\"web\",\"status\":\"completed\",\"details\":{\"totals\":{\"fee\":\"210\",\"tax\":\"0\",\"total\":\"3200\",\"credit\":\"0\",\"balance\":\"0\",\"discount\":\"0\",\"earnings\":\"2990\",\"subtotal\":\"3200\",\"grand_total\":\"3200\",\"currency_code\":\"USD\",\"credit_to_balance\":\"0\"},\"line_items\":[{\"id\":\"txnitm_01jnbnf294cyyby35zqjeb737d\",\"totals\":{\"tax\":\"0\",\"total\":\"3200\",\"discount\":\"0\",\"subtotal\":\"3200\"},\"item_id\":null,\"product\":{\"id\":\"pro_01j0vk6e4ka8kdt6ck8crpnpmc\",\"name\":\"Intellij SFCC Plugin\",\"type\":\"standard\",\"status\":\"active\",\"image_url\":null,\"created_at\":\"2024-06-20T19:50:22.099Z\",\"updated_at\":\"2025-02-13T21:49:18.676Z\",\"custom_data\":null,\"description\":null,\"tax_category\":\"saas\"},\"price_id\":\"pri_01jkvh46f2n46r065kr50zg7cn\",\"quantity\":4,\"tax_rate\":\"0\",\"unit_totals\":{\"tax\":\"0\",\"total\":\"800\",\"discount\":\"0\",\"subtotal\":\"800\"},\"is_tax_exempt\":false,\"revised_tax_exempted\":false}],\"payout_totals\":{\"fee\":\"210\",\"tax\":\"0\",\"total\":\"3200\",\"credit\":\"0\",\"balance\":\"0\",\"discount\":\"0\",\"earnings\":\"2990\",\"fee_rate\":\"0.05\",\"subtotal\":\"3200\",\"grand_total\":\"3200\",\"currency_code\":\"USD\",\"exchange_rate\":\"1\",\"credit_to_balance\":\"0\"},\"tax_rates_used\":[{\"totals\":{\"tax\":\"0\",\"total\":\"3200\",\"discount\":\"0\",\"subtotal\":\"3200\"},\"tax_rate\":\"0\"}],\"adjusted_totals\":{\"fee\":\"210\",\"tax\":\"0\",\"total\":\"3200\",\"earnings\":\"2990\",\"subtotal\":\"3200\",\"grand_total\":\"3200\",\"currency_code\":\"USD\"}},\"checkout\":{\"url\":\"https://is-paddle.ngrok.app/webhooks/external/paddle/transaction?_ptxn=txn_01jnbnf1y5fm6hhm0b5ee96dph\"},\"payments\":[{\"amount\":\"3200\",\"status\":\"captured\",\"created_at\":\"2025-03-02T14:52:38.417147Z\",\"error_code\":null,\"captured_at\":\"2025-03-02T14:52:40.436399Z\",\"method_details\":{\"card\":{\"type\":\"visa\",\"last4\":\"5556\",\"expiry_year\":2026,\"expiry_month\":10,\"cardholder_name\":\"Tester Mister\"},\"type\":\"card\"},\"payment_method_id\":\"paymtd_01jnbngj3hpmcrjcfvhw11zf4y\",\"payment_attempt_id\":\"80516daf-1563-4646-8d9b-3974c401e124\",\"stored_payment_method_id\":\"c54757bf-e07e-446c-8a78-abb1d2070551\"}],\"billed_at\":\"2025-03-02T14:52:40.67411Z\",\"address_id\":\"add_01jn9q868fdxxhpdpdw7gw2zca\",\"created_at\":\"2025-03-02T14:51:49.420508Z\",\"invoice_id\":\"inv_01jnbngmp8y2k176zat8b73rgn\",\"revised_at\":null,\"updated_at\":\"2025-03-02T14:52:42.638584346Z\",\"business_id\":\"biz_01jn9q860h7gd2rkny0zqbea0r\",\"custom_data\":{\"organizationId\":\"01955374-16eb-7fc3-97b3-c6af5bc32604\"},\"customer_id\":\"ctm_01j5kbwvwvtg8qybdr9n1qxhd6\",\"discount_id\":null,\"receipt_data\":null,\"currency_code\":\"USD\",\"billing_period\":{\"ends_at\":\"2025-04-02T14:52:40.436399Z\",\"starts_at\":\"2025-03-02T14:52:40.436399Z\"},\"invoice_number\":\"8400-10010\",\"billing_details\":null,\"collection_mode\":\"automatic\",\"subscription_id\":\"sub_01jnbngmnx842ac0mscs1h2qn6\"},\"event_id\":\"evt_01jnbngppsn3q2agrmas0sj75g\",\"event_type\":\"transaction.completed\",\"occurred_at\":\"2025-03-02T14:52:43.097635Z\",\"notification_id\":\"ntf_01jnbngptkwk2kjjr9xgd21qpv\"}";

// Create Paddle instance with logger
Paddle.Sdk.Paddle paddle = new(
    apiKey: apiKey,
    environment: PaddleEnvironment.Sandbox,
    logger: logger
);

var _jsonOptions = new JsonSerializerOptions {
    PropertyNameCaseInsensitive = true,
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
};

Event<PaddleTransaction>? transaction = JsonSerializer.Deserialize<Event<PaddleTransaction>>(jsonStr);
var test = 123;
// Get Transaction
// PaddleResponse<PaddleSubscription>? subscription = await paddle.Subscriptions.GetAsync("sub_01jn9t1b2tptna854hj87aejdr", []);
// PaddleResponse<PaddleTransaction>? transaction = await paddle.Transactions.GetAsync("txn_01jn9sbgkhq1z45a5kj7byw8k1");


Console.WriteLine("Hello, World!");