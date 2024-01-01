namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class LoginProtocol
    {
        [JsonPropertyName("internal")]
        public bool? Internal { get; set; }

        [JsonPropertyName("providers")]
        public LoginProtocolProviders Providers { get; set; }
    }
}
