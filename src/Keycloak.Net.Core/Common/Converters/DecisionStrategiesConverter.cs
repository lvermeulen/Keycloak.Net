using System;
using System.Collections.Generic;
using System.Linq;
using Keycloak.Net.Models.AuthorizationPermissions;

namespace Keycloak.Net.Common.Converters
{
    public class DecisionStrategiesConverter : JsonEnumConverter<DecisionStrategy>
    {
        private static readonly Dictionary<DecisionStrategy, string> SPairs = new Dictionary<DecisionStrategy, string>
        {
            [DecisionStrategy.Unanimous] = "UNANIMOUS",
            [DecisionStrategy.Affirmative] = "AFFIRMATIVE",
            [DecisionStrategy.Consensus] = "CONSENSUS"
        };

        protected override string EntityString { get; } = "decisionStrategy";

        protected override string ConvertToString(DecisionStrategy value) => SPairs[value];

        protected override DecisionStrategy ConvertFromString(string s)
        {
            if (SPairs.Values.Contains(s.ToUpper()))
            {
                return SPairs.First(kvp => kvp.Value.Equals(s, StringComparison.OrdinalIgnoreCase)).Key;
            }

            throw new ArgumentException($"Unknown {EntityString}: {s}");
        }
    }
}