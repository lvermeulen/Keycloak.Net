using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class Scripting
    {
        [JsonProperty("internal")]
        public bool? Internal { get; set; }

        [JsonProperty("providers")]
        public ScriptingProviders Providers { get; set; }
    }
}