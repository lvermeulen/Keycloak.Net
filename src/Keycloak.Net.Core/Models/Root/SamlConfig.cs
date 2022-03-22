using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class SamlConfig
    {
        [JsonProperty("attribute.nameformat")]
        public string AttributeNameformat { get; set; }

        [JsonProperty("user.attribute")]
        public string UserAttribute { get; set; }

        [JsonProperty("friendly.name")]
        public string FriendlyName { get; set; }

        [JsonProperty("attribute.name")]
        public string AttributeName { get; set; }

        [JsonProperty("single")]
        public bool? Single { get; set; }
    }
}