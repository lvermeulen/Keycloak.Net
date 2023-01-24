namespace Keycloak.Net.Models.Clients
{
    using Newtonsoft.Json;

    public class AccessTokenCertConf
    {
        [JsonProperty("x5t#S256")]
        public string X5Ts256 { get; set; }
    }
}
