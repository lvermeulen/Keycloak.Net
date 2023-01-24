﻿namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class BruteForceProtector
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public BruteForceProtectorProviders Providers { get; set; }
    }
}