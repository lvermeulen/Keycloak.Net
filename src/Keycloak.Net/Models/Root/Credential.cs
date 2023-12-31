namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class Credential
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public CredentialProviders Providers { get; set; }
    }
}