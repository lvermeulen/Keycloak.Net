using Newtonsoft.Json;

namespace Keycloak.Net.Models.ProtocolMappers
{
    public class ProtocolMapper
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("protocol")]
        public string Protocol { get; set; }
        [JsonProperty("protocolMapper")]
        // ReSharper disable once InconsistentNaming
        public string _ProtocolMapper { get; set; }
        [JsonProperty("consentRequired")]
        public bool? ConsentRequired { get; set; }
        [JsonProperty("config")]
        public Config Config { get; set; }
    }
}