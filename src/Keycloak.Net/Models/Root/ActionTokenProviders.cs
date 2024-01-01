namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class ActionTokenProviders
    {
        [JsonPropertyName("infinispan")]
        public HasOrder Infinispan { get; set; }
    }
}
