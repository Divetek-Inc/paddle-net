using System.Net.Http.Headers;
using System.Text.Json;
using Paddle.Sdk.Api.Addresses;
using Paddle.Sdk.Api.Customers;
using Paddle.Sdk.Api.Prices;
using Paddle.Sdk.Api.Products;

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

    #endregion

    public string ApiUrl { get; }


    // Main constructor for direct instantiation
    public Paddle(string apiKey, PaddleEnvironment environment)
        : this(apiKey, environment, new HttpClient(), true) { }

    // Constructor for DI
    public Paddle(string apiKey, PaddleEnvironment environment, HttpClient httpClient)
        : this(apiKey, environment, httpClient, false) { }

    // Private constructor for shared initialization
    private Paddle(string apiKey, PaddleEnvironment environment, HttpClient httpClient, bool ownsHttpClient) {
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
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        #region Init APIs in lazy mode

        _productsApi = new Lazy<IProductsApi>(() => new ProductsApi(_httpClient, _jsonOptions));
        _pricesApi = new Lazy<IPricesApi>(() => new PricesApi(_httpClient, _jsonOptions));
        _addressApi = new Lazy<IAddressApi>(() => new AddressApi(_httpClient, _jsonOptions));
        _customersApi = new Lazy<ICustomersApi>(() => new CustomersApi(_httpClient, _jsonOptions));

        #endregion
    }

    #region Paddle APIs

    public IProductsApi Products => _productsApi.Value;

    public IPricesApi Prices => _pricesApi.Value;

    public IAddressApi Addresses => _addressApi.Value;

    public ICustomersApi Customers => _customersApi.Value;

    #endregion

    public void Dispose() {
        if (_ownsHttpClient) _httpClient.Dispose();
    }
}