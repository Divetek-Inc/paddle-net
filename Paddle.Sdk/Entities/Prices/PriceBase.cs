using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Paddle.Sdk.Entities.Prices;

public class PriceBase : PaddleBaseEntity {
    [Description("Name of this price, shown to customers at checkout and on invoices. Typically describes how often the related product bills.")]
    public string? Name { get; set; }

    [JsonPropertyName("product_id")]
    public required string ProductId { get; set; }

    public required string Description { get; set; }

    [JsonPropertyName("unit_price")]
    public required UnitPrice UnitPrice { get; set; }

    [JsonPropertyName("tax_mode")]
    public required TaxMode TaxMode { get; set; } = TaxMode.AccountSetting;

    [JsonPropertyName("billing_cycle")]
    public BillingCycle? BillingCycle { get; set; }

    [JsonPropertyName("trial_period")]
    public TrialPeriod? TrialPeriod { get; set; }

    [JsonPropertyName("unit_price_overrides")]
    public UnitPriceOverrides? UnitPriceOverrides { get; set; }

    public Quantity? Quantity { get; set; }
}