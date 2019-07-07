using System;
using System.Collections.Generic;
using System.Linq;
using Keycloak.Net.Models.Root;

namespace Keycloak.Net.Common.Converters
{
    public class NameConverter : JsonEnumConverter<Name>
    {
        private static readonly Dictionary<Name, string> s_pairs = new Dictionary<Name, string>
        {
            [Name.Base] = "base",
            [Name.Keycloak] = "keycloak",
            [Name.RhSso] = "rh-sso"
        };

        protected override string EntityString { get; } = nameof(Name).ToLower();

        protected override string ConvertToString(Name value) => s_pairs[value];

        protected override Name ConvertFromString(string s)
        {
            var pair = s_pairs.FirstOrDefault(kvp => kvp.Value.Equals(s, StringComparison.OrdinalIgnoreCase));
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (EqualityComparer<KeyValuePair<Name, string>>.Default.Equals(pair))
            {
                throw new ArgumentException($"Unknown {EntityString}: {s}");
            }

            return pair.Key;
        }
    }
}
