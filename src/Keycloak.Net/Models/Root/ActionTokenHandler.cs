namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class ActionTokenHandler
    {
        [JsonPropertyName("internal")]
        public bool? Internal { get; set; }

        [JsonPropertyName("providers")]
        public ActionTokenHandlerProviders Providers { get; set; }
    }
}
