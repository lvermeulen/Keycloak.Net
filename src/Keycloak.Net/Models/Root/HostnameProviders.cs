using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class HostnameProviders
    {
        [JsonProperty("request")]
        public HasOrder Request { get; set; }
    }
}