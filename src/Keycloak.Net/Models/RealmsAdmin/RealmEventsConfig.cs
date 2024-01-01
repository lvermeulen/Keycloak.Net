namespace Keycloak.Net.Models.RealmsAdmin
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class RealmEventsConfig
    {
        [JsonPropertyName("adminEventsDetailsEnabled")]
        public bool? AdminEventsDetailsEnabled { get; set; }
        [JsonPropertyName("adminEventsEnabled")]
        public bool? AdminEventsEnabled { get; set; }
        [JsonPropertyName("enabledEventsTypes")]
        public IEnumerable<string> EnabledEventsTypes { get; set; }
        [JsonPropertyName("eventsEnabled")]
        public bool? EventsEnabled { get; set; }
        [JsonPropertyName("eventsExpiration")]
        public long? EventsExpiration { get; set; }
        [JsonPropertyName("eventsListeners")]
        public IEnumerable<string> EventsListeners { get; set; }
    }
}

