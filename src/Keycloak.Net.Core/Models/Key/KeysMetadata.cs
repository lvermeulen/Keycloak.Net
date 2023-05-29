using Newtonsoft.Json;
using System.Collections.Generic;

namespace Keycloak.Net.Models.Key
{
    public class KeysMetadata
    {
        [JsonProperty("active")]
        public Active Active { get; set; }
        [JsonProperty("keys")]
        public IEnumerable<Key> Keys { get; set; }
    }
}
