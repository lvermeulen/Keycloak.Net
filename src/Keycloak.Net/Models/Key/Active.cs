using Newtonsoft.Json;

namespace Keycloak.Net.Models.Key
{
    public class Active
    {
        [JsonProperty("HS256")]
        public string Hs256 { get; set; }
        [JsonProperty("RS256")]
        public string Rs256 { get; set; }
        [JsonProperty("AES")]
        public string Aes { get; set; }
    }
}