using System.Net;

namespace Paddle.Sdk.Http;

public class PaddleApiException(string message, HttpStatusCode statusCode, string responseContent) : Exception(message) {
    public HttpStatusCode StatusCode { get; } = statusCode;
    public string ResponseContent { get; } = responseContent;
    
}