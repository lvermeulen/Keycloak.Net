namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class EmailTemplateClass
    {
        [JsonPropertyName("internal")]
        public bool? Internal { get; set; }

        [JsonPropertyName("providers")]
        public AccountProviders Providers { get; set; }
    }
}
