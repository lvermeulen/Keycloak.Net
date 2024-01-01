namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class Timer
    {
        [JsonPropertyName("internal")]
        public bool? Internal { get; set; }

        [JsonPropertyName("providers")]
        public TimerProviders Providers { get; set; }
    }
}
