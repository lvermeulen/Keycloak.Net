namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class HostnameProviders
    {
        [JsonProperty("request")]
        public HasOrder Request { get; set; }
    }
}