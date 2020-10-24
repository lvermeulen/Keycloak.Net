using System;
using System.Collections.Generic;
using System.Linq;
using Keycloak.Net.Models.AuthorizationPermissions;

namespace Keycloak.Net.Common.Converters
{
    public class PolicyDecisionLogicConverter : JsonEnumConverter<PolicyDecisionLogic>
    {
        private static readonly Dictionary<PolicyDecisionLogic, string> SPairs = new Dictionary<PolicyDecisionLogic, string>
        {
            [PolicyDecisionLogic.Positive] = "POSITIVE",
            [PolicyDecisionLogic.Negative] = "NEGATIVE"
        };

        protected override string EntityString { get; } = "logic";

        protected override string ConvertToString(PolicyDecisionLogic value) => SPairs[value];

        protected override PolicyDecisionLogic ConvertFromString(string s)
        {
            if (SPairs.Values.Contains(s.ToUpper()))
            {
                return SPairs.First(kvp => kvp.Value.Equals(s, StringComparison.OrdinalIgnoreCase)).Key;
            }

            throw new ArgumentException($"Unknown {EntityString}: {s}");
        }
    }
}