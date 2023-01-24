namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class AuthorizationPersister
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public AuthorizationPersisterProviders Providers { get; set; }
    }
}