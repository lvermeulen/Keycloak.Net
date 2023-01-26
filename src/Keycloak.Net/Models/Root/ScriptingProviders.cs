namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class ScriptingProviders
    {
        [JsonProperty("script-based-auth")]
        public HasOrder ScriptBasedAuth { get; set; }
    }
}