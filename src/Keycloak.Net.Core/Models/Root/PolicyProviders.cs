using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class PolicyProviders
    {
        [JsonProperty("role")]
        public HasOrder Role { get; set; }

        [JsonProperty("resource")]
        public HasOrder Resource { get; set; }

        [JsonProperty("scope")]
        public HasOrder Scope { get; set; }

        [JsonProperty("uma")]
        public HasOrder Uma { get; set; }

        [JsonProperty("client")]
        public HasOrder Client { get; set; }

        [JsonProperty("js")]
        public HasOrder Js { get; set; }

        [JsonProperty("time")]
        public HasOrder Time { get; set; }

        [JsonProperty("user")]
        public HasOrder User { get; set; }

        [JsonProperty("aggregate")]
        public HasOrder Aggregate { get; set; }

        [JsonProperty("group")]
        public HasOrder Group { get; set; }
    }
}