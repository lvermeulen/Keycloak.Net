namespace Keycloak.Net.Models.ClientScopes
{
    using System.Collections.Generic;
    using Keycloak.Net.Models.ProtocolMappers;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public class ClientScope
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("protocol")]
        public string Protocol { get; set; }
        [JsonPropertyName("attributes")]
        public Attributes Attributes { get; set; }
        [JsonPropertyName("protocolMappers")]
        public IEnumerable<ProtocolMapper> ProtocolMappers { get; set; }
    }
}
