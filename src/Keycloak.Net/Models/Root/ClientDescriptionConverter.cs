using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class ClientDescriptionConverter
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public ClientDescriptionConverterProviders Providers { get; set; }
    }
}