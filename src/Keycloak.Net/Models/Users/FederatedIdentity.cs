namespace Keycloak.Net.Models.Users
{
    using System.Text.Json.Serialization;

    public class FederatedIdentity
    {
        [JsonPropertyName("identityProvider")]
        public string IdentityProvider { get; set; }
        [JsonPropertyName("userId")]
        public string UserId { get; set; }
        [JsonPropertyName("userName")]
        public string UserName { get; set; }
    }
}

