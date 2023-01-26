namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class JtaLookupProviders
    {
        [JsonProperty("jboss")]
        public HasOrder Jboss { get; set; }
    }
}