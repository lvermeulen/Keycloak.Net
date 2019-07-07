using System;
using System.Collections.Generic;
using System.Linq;
using Keycloak.Net.Models.Root;

namespace Keycloak.Net.Common.Converters
{
    public class LocaleConverter : JsonEnumConverter<Locale>
    {
        private static readonly Dictionary<Locale, string> s_pairs = new Dictionary<Locale, string>
        {
            [Locale.En] = "en"
        };

        protected override string EntityString { get; } = nameof(Locale).ToLower();

        protected override string ConvertToString(Locale value) => s_pairs[value];

        protected override Locale ConvertFromString(string s)
        {
            var pair = s_pairs.FirstOrDefault(kvp => kvp.Value.Equals(s, StringComparison.OrdinalIgnoreCase));
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (EqualityComparer<KeyValuePair<Locale, string>>.Default.Equals(pair))
            {
                throw new ArgumentException($"Unknown {EntityString}: {s}");
            }

            return pair.Key;
        }
    }
}
