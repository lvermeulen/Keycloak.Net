namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class TimerProviders
    {
        [JsonPropertyName("basic")]
        public HasOrder Basic { get; set; }
    }
}
