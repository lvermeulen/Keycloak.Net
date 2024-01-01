namespace Keycloak.Net.Models.RealmsAdmin
{
    using System.Text.Json.Serialization;

    public class AuthDetails
    {
        [JsonPropertyName("clientId")]
        public string ClientId { get; set; }
        [JsonPropertyName("ipAddress")]
        public string IpAddress { get; set; }
        [JsonPropertyName("realmId")]
        public string RealmId { get; set; }
        [JsonPropertyName("userId")]
        public string UserId { get; set; }
    }
}

