using System;
using System.Linq;
using System.Collections.Generic;
using Keycloak.Net.Models.AuthorizationPermissions;

namespace Keycloak.Net.Common.Converters
{
    public class AuthorizationPermissionTypeConverter: JsonEnumConverter<AuthorizationPermissionType>
    {
        private static readonly Dictionary<AuthorizationPermissionType, string> SPairs = new Dictionary<AuthorizationPermissionType, string>
        {
            [AuthorizationPermissionType.Scope] = "scope",
            [AuthorizationPermissionType.Resource] = "resource"
        };

        protected override string EntityString { get; } = "type";

        protected override string ConvertToString(AuthorizationPermissionType value) => SPairs[value];

        protected override AuthorizationPermissionType ConvertFromString(string s)
        {
            if (SPairs.Values.Contains(s.ToLower()))
            {
                return SPairs.First(kvp => kvp.Value.Equals(s, StringComparison.OrdinalIgnoreCase)).Key;
            }

            throw new ArgumentException($"Unknown {EntityString}: {s}");
        }
    }
}