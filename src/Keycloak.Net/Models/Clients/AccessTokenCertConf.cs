namespace Keycloak.Net.Models.Clients
{
    using System.Text.Json.Serialization;

    public class AccessTokenCertConf
    {
        [JsonPropertyName("x5t#S256")]
        public string X5Ts256 { get; set; }
    }
}

