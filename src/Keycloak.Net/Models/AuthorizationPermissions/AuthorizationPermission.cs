namespace Keycloak.Net.Models.AuthorizationPermissions
{
    using System.Collections.Generic;
    using Keycloak.Net.Common.Converters;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public class AuthorizationPermission
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonConverter(typeof(AuthorizationPermissionTypeConverter))]
        public AuthorizationPermissionType Type { get; set; }

        [JsonConverter(typeof(PolicyDecisionLogicConverter))]
        public PolicyDecisionLogic Logic { get; set; } 

        [JsonConverter(typeof(DecisionStrategiesConverter))]
        public DecisionStrategy DecisionStrategy { get; set; }

        [JsonPropertyName("resourceType")]
        public string ResourceType { get; set; }

        [JsonPropertyName("resources")]
        public IEnumerable<string> ResourceIds { get; set; }

        [JsonPropertyName("scopes")]
        public IEnumerable<string> ScopeIds { get; set; }

        [JsonPropertyName("policies")]
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