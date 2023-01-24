namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class ActionToken
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public ActionTokenProviders Providers { get; set; }
    }
}