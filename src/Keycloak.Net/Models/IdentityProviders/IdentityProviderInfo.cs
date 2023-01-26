namespace Keycloak.Net.Models.IdentityProviders
{
    using Newtonsoft.Json;

    public class IdentityProviderInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
