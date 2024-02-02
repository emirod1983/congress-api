using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

public class CustomDateTimeConverter : DateTimeConverterBase
{
    public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
    {
        string dateString = (string)reader?.Value;
        if (DateOnly.TryParse(dateString, out DateOnly result))
        {
            return result;
        }
        else
        {
            return null;
        }
    }

    public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
    {
        throw new NotImplementedException();
    }
}