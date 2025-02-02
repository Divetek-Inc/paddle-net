using System.Net.Http.Headers;
using System.Text.Json;
using Paddle.Sdk.Services.Products;

namespace Paddle.Sdk;

public class Paddle : IPaddle, IDisposable {
    private static Dictionary<PaddleEnvironmentType, string> ApiUrls = new() {
        { PaddleEnvironmentType.Sandbox, "https://sandbox-api.paddle.com/" },
        { PaddleEnvironmentType.Production, "https://api.paddle.com/" },
    };

    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _jsonOptions;
    private readonly Lazy<IProductsApi> _productsService;
    private readonly bool _ownsHttpClient;


    public string ApiUrl { get; }

    #region Paddle Services

    public IProductsApi Products => _productsService.Value;

    #endregion


    // Main constructor for direct instantiation
    public Paddle(string apiKey, PaddleEnvironmentType environmentType)
        : this(apiKey, environmentType, new HttpClient(), true) { }

    // Constructor for DI
    public Paddle(string apiKey, PaddleEnvironmentType environmentType, HttpClient httpClient)
        : this(apiKey, environmentType, httpClient, false) { }

    // Private constructor for shared initialization
    private Paddle(string apiKey, PaddleEnvironmentType environmentType, HttpClient httpClient, bool ownsHttpClient) {
        // Initialize properties
        ApiUrl = ApiUrls[environmentType];
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

        #region Init services in lazy mode

        // Initialize services
        _productsService = new Lazy<IProductsApi>(() => new ProductsApi(_httpClient, _jsonOptions));

        #endregion
    }


    public void Dispose() {
        if (_ownsHttpClient) {
            _httpClient.Dispose();
        }
    }
}