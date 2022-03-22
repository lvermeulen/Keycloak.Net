using Newtonsoft.Json;

namespace Keycloak.Net.Models.RealmsAdmin
{
    public class Config
    {
        [JsonProperty("hideOnLoginPage")]
        public string HideOnLoginPage { get; set; }
        [JsonProperty("clientSecret")]
        public string ClientSecret { get; set; }
        [JsonProperty("clientId")]
        public string ClientId { get; set; }
        [JsonProperty("disableUserInfo")]
        public string DisableUserInfo { get; set; }
        [JsonProperty("useJwksUrl")]
        public string UseJwksUrl { get; set; }
    }
}