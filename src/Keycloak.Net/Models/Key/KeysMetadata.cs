﻿namespace Keycloak.Net.Models.Key
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class KeysMetadata
    {
        [JsonProperty("active")]
        public Active Active { get; set; }
        [JsonProperty("keys")]
        public IEnumerable<Key> Keys { get; set; }
    }
}
