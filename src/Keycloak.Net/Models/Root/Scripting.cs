namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class Scripting
    {
        [JsonPropertyName("internal")]
        public bool? Internal { get; set; }

        [JsonPropertyName("providers")]
        public ScriptingProviders Providers { get; set; }
    }
}
