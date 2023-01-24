﻿namespace Keycloak.Net.Models.AuthenticationManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class RequiredActionProvider
    {
        [JsonProperty("alias")]
        public string Alias { get; set; }
        [JsonProperty("config")]
        public IDictionary<string, object> Config { get; set; }
        [JsonProperty("defaultAction")]
        public bool? DefaultAction { get; set; }
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("priority")]
        public int? Priority { get; set; }
        [JsonProperty("providerId")]
        public string ProviderId { get; set; }
    }
}
