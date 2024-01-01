namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class Oauth2TokenIntrospectionProviders
    {
        [JsonPropertyName("access_token")]
        public HasOrder AccessToken { get; set; }

        [JsonPropertyName("refresh_token")]
        public HasOrder RefreshToken { get; set; }

        [JsonPropertyName("requesting_party_token")]
        public HasOrder RequestingPartyToken { get; set; }
    }
}
