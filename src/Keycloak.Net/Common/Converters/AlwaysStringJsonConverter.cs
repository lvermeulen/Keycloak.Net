namespace Keycloak.Net.Common.Converters
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public class AlwaysStringJsonConverter : JsonConverter<string>
    {
        public override string Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using (JsonDocument doc = JsonDocument.ParseValue(ref reader))
            {
                var root = doc.RootElement;

                if (root.ValueKind == JsonValueKind.Array || root.ValueKind == JsonValueKind.Object)
                {
                    throw new JsonException($"Unsupported value kind: {root.ValueKind}");
                }

                return root.ToString();
            }
        }

        public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value);
        }
    }
}
