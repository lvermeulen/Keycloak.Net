namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class PolicyProviders
    {
        [JsonPropertyName("role")]
        public HasOrder Role { get; set; }

        [JsonPropertyName("resource")]
        public HasOrder Resource { get; set; }

        [JsonPropertyName("scope")]
        public HasOrder Scope { get; set; }

        [JsonPropertyName("uma")]
        public HasOrder Uma { get; set; }

        [JsonPropertyName("client")]
        public HasOrder Client { get; set; }

        [JsonPropertyName("js")]
        public HasOrder Js { get; set; }

        [JsonPropertyName("time")]
        public HasOrder Time { get; set; }

        [JsonPropertyName("user")]
        public HasOrder User { get; set; }

        [JsonPropertyName("aggregate")]
        public HasOrder Aggregate { get; set; }

        [JsonPropertyName("group")]
        public HasOrder Group { get; set; }
    }
}
