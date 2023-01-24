namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class ClientDescriptionConverter
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public ClientDescriptionConverterProviders Providers { get; set; }
    }
}