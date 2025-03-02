using System.Net.Http.Headers;
using System.Text.Json;
using Microsoft.Extensions.Logging;
using Paddle.Sdk.Api.Addresses;
using Paddle.Sdk.Api.Customers;
using Paddle.Sdk.Api.Prices;
using Paddle.Sdk.Api.Products;
using Paddle.Sdk.Api.Subscriptions;
using Paddle.Sdk.Api.Transactions;

namespace Paddle.Sdk;

public class Paddle : IPaddle, IDisposable {
    private static readonly Dictionary<PaddleEnvironment, string> ApiUrls = new() {
        { PaddleEnvironment.Sandbox, "https://sandbox-api.paddle.com/" },
        { PaddleEnvironment.Production, "https://api.paddle.com/" }
    };

    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _jsonOptions;
    private readonly bool _ownsHttpClient;

    #region Apis

    private readonly Lazy<IPricesApi> _pricesApi;
    private readonly Lazy<IProductsApi> _productsApi;
    private readonly Lazy<IAddressApi> _addressApi;
    private readonly Lazy<ICustomersApi> _customersApi;
    private readonly Lazy<ISubscriptionsApi> _subscriptionsApi;
    private readonly Lazy<ITransactionsApi> _transactionsApi;

    #endregion

    public string ApiUrl { get; }


    // Main constructor for direct instantiation
    public Paddle(string apiKey, PaddleEnvironment environment, ILogger? logger = null)
        : this(apiKey, environment, new HttpClient(), true, logger: logger) { }

    // Constructor for DI
    public Paddle(string apiKey, PaddleEnvironment environment, HttpClient httpClient)
        : this(apiKey, environment, httpClient, false) { }

    // Private constructor for shared initialization
    private Paddle(string apiKey, PaddleEnvironment environment, HttpClient httpClient, bool ownsHttpClient, ILogger? logger = null) {
        // Initialize properties
        ApiUrl = ApiUrls[environment];
        _httpClient = httpClient;
        _ownsHttpClient = ownsHttpClient;

        // Configure HttpClient
        _httpClient.BaseAddress = new Uri(ApiUrl);
        _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
        _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        _jsonOptions = new JsonSerializerOptions {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        };

        #region Init APIs in lazy mode

        _productsApi = new Lazy<IProductsApi>(() => new ProductsApi(_httpClient, _jsonOptions, logger));
        _pricesApi = new Lazy<IPricesApi>(() => new PricesApi(_httpClient, _jsonOptions, logger));
        _addressApi = new Lazy<IAddressApi>(() => new AddressApi(_httpClient, _jsonOptions, logger));
        _customersApi = new Lazy<ICustomersApi>(() => new CustomersApi(_httpClient, _jsonOptions, logger));
        _subscriptionsApi = new Lazy<ISubscriptionsApi>(() => new SubscriptionsApi(_httpClient, _jsonOptions, logger));
        _transactionsApi = new Lazy<ITransactionsApi>(() => new TransactionsApi(_httpClient, _jsonOptions, logger));

        #endregion
    }

    #region Paddle APIs

    public IProductsApi Products => _productsApi.Value;

    public IPricesApi Prices => _pricesApi.Value;

    public IAddressApi Addresses => _addressApi.Value;

    public ICustomersApi Customers => _customersApi.Value;

    public ISubscriptionsApi Subscriptions => _subscriptionsApi.Value;

    public ITransactionsApi Transactions => _transactionsApi.Value;

    #endregion

    public T Deserialize<T>(string json) {
        return JsonSerializer.Deserialize<T>(json, _jsonOptions)!;
    }

    public string Serialize<T>(T obj) {
        return JsonSerializer.Serialize(obj, _jsonOptions);
    }

    public void Dispose() {
        if (_ownsHttpClient) _httpClient.Dispose();
    }
}