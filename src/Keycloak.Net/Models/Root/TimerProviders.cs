namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class TimerProviders
    {
        [JsonProperty("basic")]
        public HasOrder Basic { get; set; }
    }
}