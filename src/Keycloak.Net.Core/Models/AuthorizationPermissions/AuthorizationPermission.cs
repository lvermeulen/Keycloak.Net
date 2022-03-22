using System.Collections.Generic;
using Keycloak.Net.Common.Converters;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.AuthorizationPermissions
{
    public class AuthorizationPermission
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonConverter(typeof(AuthorizationPermissionTypeConverter))]
        public AuthorizationPermissionType Type { get; set; }

        [JsonConverter(typeof(PolicyDecisionLogicConverter))]
        public PolicyDecisionLogic Logic { get; set; } 

        [JsonConverter(typeof(DecisionStrategiesConverter))]
        public DecisionStrategy DecisionStrategy { get; set; }

        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("resources")]
        public IEnumerable<string> ResourceIds { get; set; }

        [JsonProperty("scopes")]
        public IEnumerable<string> ScopeIds { get; set; }

        [JsonProperty("policies")]
        public IEnumerable<string> PolicyIds { get; set; }
    }

    public enum PolicyDecisionLogic
    {
        Positive, 
        Negative
    }

    public enum AuthorizationPermissionType
    {   
        Scope, 
        Resource
    }

    public enum DecisionStrategy
    {
        Unanimous, 
        Affirmative, 
        Consensus
    }
}