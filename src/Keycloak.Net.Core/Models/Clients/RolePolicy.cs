using System.Collections.Generic;
using Keycloak.Net.Common.Converters;
using Keycloak.Net.Models.AuthorizationPermissions;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.Clients
{
    public class Policy
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonConverter(typeof(PolicyTypeConverter))]
        public PolicyType Type { get; set; }

        [JsonConverter(typeof(PolicyDecisionLogicConverter))]
        public PolicyDecisionLogic Logic { get; set; } 

        [JsonConverter(typeof(DecisionStrategiesConverter))]
        public DecisionStrategy DecisionStrategy { get; set; }

        [JsonProperty("config")]
        public PolicyConfig Config { get; set; }
    }

    public class RolePolicy
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonConverter(typeof(PolicyTypeConverter))]
        public PolicyType Type { get; set; } = PolicyType.Role;

        [JsonConverter(typeof(PolicyDecisionLogicConverter))]
        public PolicyDecisionLogic Logic { get; set; } 

        [JsonConverter(typeof(DecisionStrategiesConverter))]
        public DecisionStrategy DecisionStrategy { get; set; }

        [JsonProperty("roles")]
        public IEnumerable<RoleConfig> RoleConfigs { get; set; }
    }

    public class RoleConfig
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("required")]
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
        [JsonProperty("roles")]
        public IEnumerable<RoleConfig> RoleConfigs { get; set; }
    }
}