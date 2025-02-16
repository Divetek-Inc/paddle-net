using System.Text.Json;

namespace Paddle.Sdk.Entities.Events;

public class UnknownEventData
{
    public JsonElement RawData { get; set; }
    
    public Dictionary<string, object> AsDictionary() 
        => JsonSerializer.Deserialize<Dictionary<string, object>>(RawData.GetRawText())!;
}