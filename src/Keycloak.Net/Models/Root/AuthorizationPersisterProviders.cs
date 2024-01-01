namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class AuthorizationPersisterProviders
    {
        [JsonPropertyName("jpa")]
        public HasOrder Jpa { get; set; }
    }
}
