namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class AuthorizationPersisterProviders
    {
        [JsonProperty("jpa")]
        public HasOrder Jpa { get; set; }
    }
}