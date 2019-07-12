using System;
using System.Collections.Generic;
using System.Linq;
using Keycloak.Net.Models.Clients;

namespace Keycloak.Net.Common.Converters
{
    public class AccessTokenCategoriesConverter : JsonEnumConverter<AccessTokenCategories>
    {
        private static readonly Dictionary<AccessTokenCategories, string> s_pairs = new Dictionary<AccessTokenCategories, string>
        {
            [AccessTokenCategories.Internal] = "INTERNAL", 
            [AccessTokenCategories.Access] = "ACCESS", 
            [AccessTokenCategories.Id] = "ID", 
            [AccessTokenCategories.Admin] = "ADMIN", 
            [AccessTokenCategories.Userinfo] = "USERINFO"
        };

        protected override string EntityString { get; } = "access token category";

        protected override string ConvertToString(AccessTokenCategories value) => s_pairs[value];

        protected override AccessTokenCategories ConvertFromString(string s)
        {
            var pair = s_pairs.FirstOrDefault(kvp => kvp.Value.Equals(s, StringComparison.OrdinalIgnoreCase));
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (EqualityComparer<KeyValuePair<AccessTokenCategories, string>>.Default.Equals(pair))
            {
                throw new ArgumentException($"Unknown {EntityString}: {s}");
            }

            return pair.Key;
        }
    }
}
