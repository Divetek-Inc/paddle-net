namespace Paddle.Sdk.Config;

public class PaddleOptions {
    public string ApiKey { get; set; }

    public PaddleEnvironmentType Environment { get; set; }
    
    public TimeSpan Timeout { get; set; }
}