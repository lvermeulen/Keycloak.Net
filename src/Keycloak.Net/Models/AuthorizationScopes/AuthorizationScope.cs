namespace Keycloak.Net.Models.AuthorizationScopes
{
    using Newtonsoft.Json;

    public class AuthorizationScope
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
