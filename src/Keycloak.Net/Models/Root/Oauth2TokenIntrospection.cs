namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class Oauth2TokenIntrospection
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public Oauth2TokenIntrospectionProviders Providers { get; set; }
    }
}