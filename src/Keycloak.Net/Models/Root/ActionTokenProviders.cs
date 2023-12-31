namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class ActionTokenProviders
    {
        [JsonProperty("infinispan")]
        public HasOrder Infinispan { get; set; }
    }
}