using System;
using System.Collections.Generic;
using System.Linq;
using Keycloak.Net.Models.Root;

namespace Keycloak.Net.Common.Converters
{
    public class ConfigTypeConverter : JsonEnumConverter<ConfigType>
    {
        private static readonly Dictionary<ConfigType, string> s_pairs = new Dictionary<ConfigType, string>
        {
            [ConfigType.Int] = "int",
            [ConfigType.String] = "string"
        };

        protected override string EntityString { get; } = nameof(ConfigType).ToLower();

        protected override string ConvertToString(ConfigType value) => s_pairs[value];

        protected override ConfigType ConvertFromString(string s)
        {
            var pair = s_pairs.FirstOrDefault(kvp => kvp.Value.Equals(s, StringComparison.OrdinalIgnoreCase));
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (EqualityComparer<KeyValuePair<ConfigType, string>>.Default.Equals(pair))
            {
                throw new ArgumentException($"Unknown {EntityString}: {s}");
            }

            return pair.Key;
        }
    }
}
