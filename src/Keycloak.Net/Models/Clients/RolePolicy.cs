namespace Keycloak.Net.Models.Clients
{
    using System.Collections.Generic;
    using Keycloak.Net.Common.Converters;
    using Keycloak.Net.Models.AuthorizationPermissions;
    using System.Text.Json.Serialization;

    public class Policy
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonConverter(typeof(PolicyTypeConverter))]
        public PolicyType Type { get; set; }

        [JsonConverter(typeof(PolicyDecisionLogicConverter))]
        public PolicyDecisionLogic Logic { get; set; } 

        [JsonConverter(typeof(DecisionStrategiesConverter))]
        public DecisionStrategy DecisionStrategy { get; set; }

        [JsonPropertyName("config")]
        public PolicyConfig Config { get; set; }
    }

    public class RolePolicy
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonConverter(typeof(PolicyTypeConverter))]
        public PolicyType Type { get; set; } = PolicyType.Role;

        [JsonConverter(typeof(PolicyDecisionLogicConverter))]
        public PolicyDecisionLogic Logic { get; set; } 

        [JsonConverter(typeof(DecisionStrategiesConverter))]
        public DecisionStrategy DecisionStrategy { get; set; }

        [JsonPropertyName("roles")]
        public IEnumerable<RoleConfig> RoleConfigs { get; set; }
    }

    public class RoleConfig
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("required")]
        public bool Required { get; set; }
    }

    public enum PolicyType
    {
        Role,
        Client,
        Time,
        User,
        Aggregate,
        Group,
        Js
    }

    public class PolicyConfig
    {
        [JsonPropertyName("roles")]
        public IEnumerable<RoleConfig> RoleConfigs { get; set; }
    }
}

