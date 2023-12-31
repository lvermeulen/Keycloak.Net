namespace Keycloak.Net.Models.ClientScopes
{
    using Newtonsoft.Json;

    public class Attributes
    {
        [JsonProperty("consentscreentext")]
        public string ConsentScreenText { get; set; }
        [JsonProperty("displayonconsentscreen")]
        public string DisplayOnConsentScreen { get; set; }
        [JsonProperty("includeintokenscope")]
        public string IncludeInTokenScope { get; set; }
    }
}