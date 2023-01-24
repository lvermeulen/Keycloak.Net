namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class EventsListenerProviders
    {
        [JsonProperty("jboss-logging")]
        public HasOrder JbossLogging { get; set; }

        [JsonProperty("email")]
        public HasOrder Email { get; set; }
    }
}