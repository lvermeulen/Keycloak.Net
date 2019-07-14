using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class Oauth2TokenIntrospection
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public Oauth2TokenIntrospectionProviders Providers { get; set; }
    }
}