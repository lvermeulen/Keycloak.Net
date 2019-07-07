using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class JtaLookupProviders
    {
        [JsonProperty("jboss")]
        public HasOrder Jboss { get; set; }
    }
}