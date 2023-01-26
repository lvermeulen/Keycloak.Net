namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class AuthorizationProviders
    {
        [JsonProperty("authorization")]
        public HasOrder Authorization { get; set; }
    }
}