namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class LoginProtocol
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public LoginProtocolProviders Providers { get; set; }
    }
}