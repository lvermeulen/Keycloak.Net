namespace Keycloak.Net.Models.Clients
{
    using System.Text.Json.Serialization;

    public class ClientConfig
    {
        [JsonPropertyName("userinfotokenclaim")]
        public string UserInfoTokenClaim { get; set; }
        [JsonPropertyName("userattribute")]
        public string UserAttribute { get; set; }
        [JsonPropertyName("idtokenclaim")]
        public string IdTokenClaim { get; set; }
        [JsonPropertyName("accesstokenclaim")]
        public string AccessTokenClaim { get; set; }
        [JsonPropertyName("claimname")]
        public string ClaimName { get; set; }
        [JsonPropertyName("jsonTypelabel")]
        public string JsonTypelabel { get; set; }
    }
}
