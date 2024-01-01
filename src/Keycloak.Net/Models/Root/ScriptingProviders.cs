namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class ScriptingProviders
    {
        [JsonPropertyName("script-based-auth")]
        public HasOrder ScriptBasedAuth { get; set; }
    }
}
