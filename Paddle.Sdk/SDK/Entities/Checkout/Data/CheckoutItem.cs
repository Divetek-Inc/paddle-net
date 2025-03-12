using System.Text.Json.Serialization;
using Paddle.Sdk.Entities.Shared;

namespace Paddle.Sdk.SDK.Entities.Checkout.Data;

public class CheckoutItem
{
    [JsonPropertyName("price_id")]
    public required string PriceId { get; set; }
    
    [JsonPropertyName("price_name")]
    public required string PriceName { get; set; }
    
    public required CheckoutProduct Product { get; set; }
    
    [JsonPropertyName("billing_cycle")]
    public required BillingCycle BillingCycle { get; set; }
    
    [JsonPropertyName("trial_period")]
    public object? TrialPeriod { get; set; }
    
    public required int Quantity { get; set; }
    
    public required CheckoutTotals Totals { get; set; }
    
    [JsonPropertyName("recurring_totals")]
    public required CheckoutTotals RecurringTotals { get; set; }
}