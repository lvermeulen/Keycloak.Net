namespace Keycloak.Net.Models.AuthorizationResources
{
    using Keycloak.Net.Models.AuthorizationScopes;
    using System.Text.Json;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class AuthorizationResource
    {
        [JsonPropertyName("_id")]
        public string Id { get; set; }
        [JsonPropertyName("scopes")]
        public IEnumerable<AuthorizationScope> Scopes { get; set; }
        [JsonPropertyName("attributes")]
        public Dictionary<string, IEnumerable<string>> Attributes { get; set; }
        [JsonPropertyName("uris")]
        public IEnumerable<string> Uris { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("ownerManagedAccess")]
        public bool? OwnerManagedAccess { get; set; }
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; } 
    }
}
