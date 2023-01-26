namespace Keycloak.Net.Models.ClientScopes
{
    using System.Collections.Generic;
    using ProtocolMappers;
    using Newtonsoft.Json;

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
