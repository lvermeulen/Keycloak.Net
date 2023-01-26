namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class Timer
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public TimerProviders Providers { get; set; }
    }
}