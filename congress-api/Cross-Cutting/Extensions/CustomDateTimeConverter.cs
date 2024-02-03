using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Text.RegularExpressions;

public class CustomDateTimeConverter : DateTimeConverterBase
{
    public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
    {
        string slashedDate = "^(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/\\d{4}$"; // This shuld be doable with CultureInfo

        if (reader?.Value is DateTime)
        {
            return DateOnly.FromDateTime((DateTime)reader.Value);
        }

        if (string.Equals(reader.Value.ToString(),"07/12/2023")) { 
            Console.WriteLine(slashedDate);
        }
        
        if (Regex.IsMatch(reader?.Value.ToString(), slashedDate))
        {
            DateTime parsedDate = DateTime.ParseExact(reader?.Value.ToString(), "dd/MM/yyyy", null);
            return DateOnly.FromDateTime(parsedDate);
        }

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