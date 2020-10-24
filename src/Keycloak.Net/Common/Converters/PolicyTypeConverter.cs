using System;
using System.Collections.Generic;
using System.Linq;
using Keycloak.Net.Models.Clients;

namespace Keycloak.Net.Common.Converters
{
    public class PolicyTypeConverter: JsonEnumConverter<PolicyType>
    {
        private static readonly Dictionary<PolicyType, string> SPairs = new Dictionary<PolicyType, string>
        {
            [PolicyType.Role] = "role",
            [PolicyType.Client] = "client",
            [PolicyType.Time] = "time",
            [PolicyType.User] = "user",
            [PolicyType.Aggregate] = "aggregate",
            [PolicyType.Group] = "group",
            [PolicyType.Js] = "js"
        };

        protected override string EntityString { get; } = "type";

        protected override string ConvertToString(PolicyType value) => SPairs[value];

        protected override PolicyType ConvertFromString(string s)
        {
            if (SPairs.Values.Contains(s.ToLower()))
            {
                return SPairs.First(kvp => kvp.Value.Equals(s, StringComparison.OrdinalIgnoreCase)).Key;
            }

            throw new ArgumentException($"Unknown {EntityString}: {s}");
        }
    }
}