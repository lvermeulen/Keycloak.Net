namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class Oauth2TokenIntrospectionProviders
    {
        [JsonProperty("access_token")]
        public HasOrder AccessToken { get; set; }

        [JsonProperty("refresh_token")]
        public HasOrder RefreshToken { get; set; }

        [JsonProperty("requesting_party_token")]
        public HasOrder RequestingPartyToken { get; set; }
    }
}