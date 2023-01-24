namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class Saml
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
        public SamlConfig Config { get; set; }
    }
}