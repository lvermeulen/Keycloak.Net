namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class ActionToken
    {
        [JsonPropertyName("internal")]
        public bool? Internal { get; set; }

        [JsonPropertyName("providers")]
        public ActionTokenProviders Providers { get; set; }
    }
}
