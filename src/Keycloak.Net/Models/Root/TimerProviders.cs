using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class TimerProviders
    {
        [JsonProperty("basic")]
        public HasOrder Basic { get; set; }
    }
}