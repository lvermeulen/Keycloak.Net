namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class AuthorizationCache
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public HasDefault Providers { get; set; }
    }
}