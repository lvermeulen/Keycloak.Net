using System;
using System.Collections.Generic;
using System.Linq;
using Keycloak.Net.Models.Root;

namespace Keycloak.Net.Common.Converters
{
    public class GroupNameConverter : JsonEnumConverter<GroupName>
    {
        private static readonly Dictionary<GroupName, string> s_pairs = new Dictionary<GroupName, string>
        {
            [GroupName.Social] = "social",
            [GroupName.UserDefined] = "userdefined"
        };

        protected override string EntityString { get; } = nameof(GroupName).ToLower();

        protected override string ConvertToString(GroupName value) => s_pairs[value];

        protected override GroupName ConvertFromString(string s)
        {
            var pair = s_pairs.FirstOrDefault(kvp => kvp.Value.Equals(s, StringComparison.OrdinalIgnoreCase));
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (EqualityComparer<KeyValuePair<GroupName, string>>.Default.Equals(pair))
            {
                throw new ArgumentException($"Unknown {EntityString}: {s}");
            }

            return pair.Key;
        }
    }
}
