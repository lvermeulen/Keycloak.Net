namespace Keycloak.Net.Common.Converters
{
    using System;
    using System.Text.Json.Serialization;
    using System.Text.Json;

    public class BooleanJsonConverter : JsonConverter<bool?>
    {
        public override bool? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.True || reader.TokenType == JsonTokenType.False)
            {
                return reader.GetBoolean();
            }

            if (reader.TokenType == JsonTokenType.String && bool.TryParse(reader.GetString(), out var boolValue))
            {
                return boolValue;
            }

            return null;
        }

        public override void Write(Utf8JsonWriter writer, bool? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
            {
                writer.WriteStringValue(value.Value.ToString().ToLowerInvariant());
            }
            else
            {
                writer.WriteNullValue();
            }
        }
    }
}
