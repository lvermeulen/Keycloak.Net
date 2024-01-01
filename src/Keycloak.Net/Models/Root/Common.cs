namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class Common
    {
        [JsonPropertyName("name")]
        public Name Name { get; set; }
    }
}
