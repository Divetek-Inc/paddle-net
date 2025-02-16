using System.Text.Json;
using System.Text.Json.Serialization;
using Paddle.Sdk.Entities.Events;
using Paddle.Sdk.Entities.Shared;
using Paddle.Sdk.Entities.Shared.EnumParsers;

namespace Paddle.Sdk.Json.Converters;

public class PaddleEventConverter : JsonConverter<Event> {
    public override Event Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
        if (reader.TokenType != JsonTokenType.StartObject) {
            throw new JsonException("Expected start of object");
        }

        using JsonDocument jsonDoc = JsonDocument.ParseValue(ref reader);
        JsonElement rootElement = jsonDoc.RootElement;

        // First, get the event type
        string? eventTypeStr = rootElement.GetProperty("event_type").GetString();
        EventType eventType = PaddleEnumParser<EventType>.FromString(eventTypeStr);

        // Get the corresponding data type (will return UnknownEventData if no match)
        Type dataType = EventTypeMapping.GetDataType(eventType);
        Type genericEventType = typeof(Event<>).MakeGenericType(dataType);

        // If it's an unknown type, create Event<UnknownEventData> with raw JSON
        if (dataType == typeof(UnknownEventData)) {
            Event<UnknownEventData> unknownEvent = (Event<UnknownEventData>)Activator.CreateInstance(genericEventType)!;
            unknownEvent.EventId = rootElement.GetProperty("event_id").GetString()!;
            unknownEvent.EventType = eventType;
            unknownEvent.OccurredAt = rootElement.GetProperty("occurred_at").GetDateTime();
            unknownEvent.NotificationId = rootElement.GetProperty("notification_id").GetString()!;
            unknownEvent.Data = new UnknownEventData {
                RawData = rootElement.GetProperty("data")
            };
            return unknownEvent;
        }

        // Otherwise deserialize normally
        return (Event)JsonSerializer.Deserialize(
            rootElement.GetRawText(),
            genericEventType,
            options)!;
    }

    public override void Write(Utf8JsonWriter writer, Event value, JsonSerializerOptions options) {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}