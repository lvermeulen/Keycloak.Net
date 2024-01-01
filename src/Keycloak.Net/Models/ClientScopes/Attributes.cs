namespace Keycloak.Net.Models.ClientScopes
{
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public class Attributes
    {
        [JsonPropertyName("consentscreentext")]
        public string ConsentScreenText { get; set; }
        [JsonPropertyName("displayonconsentscreen")]
        public string DisplayOnConsentScreen { get; set; }
        [JsonPropertyName("includeintokenscope")]
        public string IncludeInTokenScope { get; set; }
    }
}