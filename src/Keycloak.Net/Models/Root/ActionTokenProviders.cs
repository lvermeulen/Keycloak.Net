using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class ActionTokenProviders
    {
        [JsonProperty("infinispan")]
        public HasOrder Infinispan { get; set; }
    }
}