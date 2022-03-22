using System;
using System.Collections.Generic;
using System.Linq;
using Keycloak.Net.Models.Root;

namespace Keycloak.Net.Common.Converters
{
    public class CategoryConverter : JsonEnumConverter<Category>
    {
        private static readonly Dictionary<Category, string> s_pairs = new Dictionary<Category, string>
        {
            [Category.AttributeStatementMapper] = "attribute statement mapper",
            [Category.DockerAuthMapper] = "docker auth mapper",
            [Category.GroupMapper] = "group mapper",
            [Category.RoleMapper] = "role mapper",
            [Category.TokenMapper] = "token mapper"
        };

        protected override string EntityString { get; } = nameof(Category).ToLower();

        protected override string ConvertToString(Category value) => s_pairs[value];

        protected override Category ConvertFromString(string s)
        {
            var pair = s_pairs.FirstOrDefault(kvp => kvp.Value.Equals(s, StringComparison.OrdinalIgnoreCase));
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (EqualityComparer<KeyValuePair<Category, string>>.Default.Equals(pair))
            {
                throw new ArgumentException($"Unknown {EntityString}: {s}");
            }

            return pair.Key;
        }
    }
}
