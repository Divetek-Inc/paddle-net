namespace Paddle.Sdk.Dto.Shared;

public class PaddleResponse<T> where T : class {
    public T? Data { get; set; }

    public Meta Meta { get; set; }
}