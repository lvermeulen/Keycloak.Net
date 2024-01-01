namespace Keycloak.Net.Models.Key
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class KeysMetadata
    {
        [JsonPropertyName("active")]
        public Active Active { get; set; }
        [JsonPropertyName("keys")]
        public IEnumerable<Key> Keys { get; set; }
    }
}

