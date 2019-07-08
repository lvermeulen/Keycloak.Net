using System.Collections.Generic;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.Key
{
    public class KeysMetadataRepresentation
    {
        [JsonProperty("active")]
        public Active Active { get; set; }
        [JsonProperty("keys")]
        public IEnumerable<Key> Keys { get; set; }
    }
}
