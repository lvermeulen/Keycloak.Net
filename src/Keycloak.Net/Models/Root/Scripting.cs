namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class Scripting
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public ScriptingProviders Providers { get; set; }
    }
}