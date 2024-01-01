namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class RequiredAction
    {
        [JsonPropertyName("internal")]
        public bool? Internal { get; set; }

        [JsonPropertyName("providers")]
        public RequiredActionProviders Providers { get; set; }
    }
}
