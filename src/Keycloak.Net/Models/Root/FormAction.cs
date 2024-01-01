namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class FormAction
    {
        [JsonPropertyName("internal")]
        public bool? Internal { get; set; }

        [JsonPropertyName("providers")]
        public FormActionProviders Providers { get; set; }
    }
}
