namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class HasDefault
    {
        [JsonPropertyName("default")]
        public HasOrder Default { get; set; }
    }
}
