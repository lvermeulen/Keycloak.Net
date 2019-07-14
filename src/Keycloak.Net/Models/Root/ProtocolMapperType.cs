using System.Collections.Generic;
using Keycloak.Net.Models.Common;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class ProtocolMapperType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("category")]
        public Category Category { get; set; }

        [JsonProperty("helpText")]
        public string HelpText { get; set; }

        [JsonProperty("priority")]
        public long Priority { get; set; }

        [JsonProperty("properties")]
        public List<ConfigProperty> Properties { get; set; }
    }
}