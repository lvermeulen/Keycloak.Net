using System;
using System.Collections.Generic;
using System.Linq;
using Keycloak.Net.Models.RealmsAdmin;

namespace Keycloak.Net.Common.Converters
{
    public class PoliciesConverter : JsonEnumConverter<Policies>
    {
        private static readonly Dictionary<Policies, string> s_pairs = new Dictionary<Policies, string>
        {
            [Policies.Skip] = "SKIP",
            [Policies.Overwrite] = "OVERWRITE",
            [Policies.Fail] = "FAIL"
        };

        protected override string EntityString { get; } = "policy";

        protected override string ConvertToString(Policies value) => s_pairs[value];

        protected override Policies ConvertFromString(string s)
        {
            var pair = s_pairs.FirstOrDefault(kvp => kvp.Value.Equals(s, StringComparison.OrdinalIgnoreCase));
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (EqualityComparer<KeyValuePair<Policies, string>>.Default.Equals(pair))
            {
                throw new ArgumentException($"Unknown {EntityString}: {s}");
            }

            return pair.Key;
        }
    }
}
