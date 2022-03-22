using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class HasDefault
    {
        [JsonProperty("default")]
        public HasOrder Default { get; set; }
    }
}