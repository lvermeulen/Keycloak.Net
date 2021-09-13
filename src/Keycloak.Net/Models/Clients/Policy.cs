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
}