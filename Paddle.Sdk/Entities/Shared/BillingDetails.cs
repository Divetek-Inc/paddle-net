using System.Text.Json.Serialization;

namespace Paddle.Sdk.Entities.Shared;

public class BillingDetails {
    [JsonPropertyName("payment_terms")]
    public PaymentTerms PaymentTerms { get; set; }

    [JsonPropertyName("purchase_order_number")]
    public string PurchaseOrderNumber { get; set; }

    [JsonPropertyName("enable_checkout")]
    public bool EnableCheckout { get; set; }

    [JsonPropertyName("additional_information")]
    public string AdditionalInformation { get; set; }
}