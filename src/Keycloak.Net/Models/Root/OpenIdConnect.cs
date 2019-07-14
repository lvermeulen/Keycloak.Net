using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class OpenIdConnect
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("protocol")]
        public Protocol Protocol { get; set; }

        [JsonProperty("protocolMapper")]
        public string ProtocolMapper { get; set; }

        [JsonProperty("consentRequired")]
        public bool? ConsentRequired { get; set; }

        [JsonProperty("config")]
        public OpenIdConnectConfig Config { get; set; }
    }
}