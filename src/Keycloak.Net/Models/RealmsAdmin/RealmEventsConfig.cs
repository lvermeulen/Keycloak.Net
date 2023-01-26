﻿namespace Keycloak.Net.Models.RealmsAdmin
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class RealmEventsConfig
    {
        [JsonProperty("adminEventsDetailsEnabled")]
        public bool? AdminEventsDetailsEnabled { get; set; }
        [JsonProperty("adminEventsEnabled")]
        public bool? AdminEventsEnabled { get; set; }
        [JsonProperty("enabledEventsTypes")]
        public IEnumerable<string> EnabledEventsTypes { get; set; }
        [JsonProperty("eventsEnabled")]
        public bool? EventsEnabled { get; set; }
        [JsonProperty("eventsExpiration")]
        public long? EventsExpiration { get; set; }
        [JsonProperty("eventsListeners")]
        public IEnumerable<string> EventsListeners { get; set; }
    }
}
