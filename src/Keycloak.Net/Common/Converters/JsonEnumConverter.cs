namespace Keycloak.Net.Common.Converters
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public abstract class JsonEnumConverter<TEnum> : JsonConverter<TEnum>
        where TEnum : struct, IConvertible
    {
        protected abstract string EntityString { get; }

        protected abstract string ConvertToString(TEnum value);

        protected abstract TEnum ConvertFromString(string s);

        public override TEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.StartArray)
            {
                var items = new List<TEnum>();
                using (JsonDocument doc = JsonDocument.ParseValue(ref reader))
                {
                    foreach (JsonElement element in doc.RootElement.EnumerateArray())
                    {
                        items.Add(ConvertFromString(element.ToString()));
                    }
                }
                return items.Count > 0 ? items[0] : default(TEnum);
            }

            return ConvertFromString(reader.GetString());
        }

        public override void Write(Utf8JsonWriter writer, TEnum value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(ConvertToString(value));
        }
    }
}
