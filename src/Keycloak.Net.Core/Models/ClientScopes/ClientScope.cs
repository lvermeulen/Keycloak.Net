using System.Collections.Generic;
using Keycloak.Net.Models.ProtocolMappers;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.ClientScopes
{
    public class ClientScope
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("protocol")]
        public string Protocol { get; set; }
        [JsonProperty("attributes")]
        public Attributes Attributes { get; set; }
        [JsonProperty("protocolMappers")]
        public IEnumerable<ProtocolMapper> ProtocolMappers { get; set; }
    }
}
