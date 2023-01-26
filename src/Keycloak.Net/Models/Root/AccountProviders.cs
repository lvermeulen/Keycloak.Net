namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class AccountProviders
    {
        [JsonProperty("freemarker")]
        public HasOrder Freemarker { get; set; }
    }
}