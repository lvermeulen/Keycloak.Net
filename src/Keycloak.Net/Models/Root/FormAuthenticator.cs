namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class FormAuthenticator
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public FormAuthenticatorProviders Providers { get; set; }
    }
}