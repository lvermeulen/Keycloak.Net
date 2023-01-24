namespace Keycloak.Net.Models.Root
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class Authenticator
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public Dictionary<string, HasOrder> Providers { get; set; }
    }
}