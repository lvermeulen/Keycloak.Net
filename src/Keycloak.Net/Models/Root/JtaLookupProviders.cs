namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class JtaLookupProviders
    {
        [JsonPropertyName("jboss")]
        public HasOrder Jboss { get; set; }
    }
}
