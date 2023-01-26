namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class EventsListener
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public EventsListenerProviders Providers { get; set; }
    }
}