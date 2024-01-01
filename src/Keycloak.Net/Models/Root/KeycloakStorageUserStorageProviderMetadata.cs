namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class KeycloakStorageUserStorageProviderMetadata
    {
        [JsonPropertyName("synchronizable")]
        public bool? Synchronizable { get; set; }
    }
}
