using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class LoginProtocol
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public LoginProtocolProviders Providers { get; set; }
    }
}