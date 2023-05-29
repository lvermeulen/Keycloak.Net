using Newtonsoft.Json;
using System.Collections.Generic;

namespace Keycloak.Net.Models.Clients
{
    public class ClientProtocolMapper
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("protocol")]
        public string Protocol { get; set; }
        [JsonProperty("protocolMapper")]
        public string ProtocolMapper { get; set; }
        [JsonProperty("consentRequired")]
        public bool? ConsentRequired { get; set; }
        [JsonProperty("config")]
        public Dictionary<string, string> Config { get; set; }
    }
}