using System;
using System.Collections.Generic;
using System.Linq;
using Keycloak.Net.Models.Root;

namespace Keycloak.Net.Common.Converters
{
    public class JsonTypeLabelConverter : JsonEnumConverter<JsonTypeLabel>
    {
        private static readonly Dictionary<JsonTypeLabel, string> s_pairs = new Dictionary<JsonTypeLabel, string>
        {
            [JsonTypeLabel.Boolean] = "boolean",
            [JsonTypeLabel.ClientList] = "clientlist",
            [JsonTypeLabel.File] = "file",
            [JsonTypeLabel.List] = "list",
            [JsonTypeLabel.MultivaluedList] = "multivaluedlist",
            [JsonTypeLabel.MultivaluedString] = "multivaluedstring",
            [JsonTypeLabel.Password] = "password",
            [JsonTypeLabel.Role] = "role",
            [JsonTypeLabel.Script] = "script",
            [JsonTypeLabel.String] = "string",
            [JsonTypeLabel.Text] = "text"
        };

        protected override string EntityString { get; } = nameof(JsonTypeLabel).ToLower();

        protected override string ConvertToString(JsonTypeLabel value) => s_pairs[value];

        protected override JsonTypeLabel ConvertFromString(string s)
        {
            var pair = s_pairs.FirstOrDefault(kvp => kvp.Value.Equals(s, StringComparison.OrdinalIgnoreCase));
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (EqualityComparer<KeyValuePair<JsonTypeLabel, string>>.Default.Equals(pair))
            {
                throw new ArgumentException($"Unknown {EntityString}: {s}");
            }

            return pair.Key;
        }
    }
}
