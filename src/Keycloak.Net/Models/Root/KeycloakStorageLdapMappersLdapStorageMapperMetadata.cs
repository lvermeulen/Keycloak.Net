namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class KeycloakStorageLdapMappersLdapStorageMapperMetadata
    {
        [JsonPropertyName("fedToKeycloakSyncSupported")]
        public bool? FedToKeycloakSyncSupported { get; set; }

        [JsonPropertyName("keycloakToFedSyncSupported")]
        public bool? KeycloakToFedSyncSupported { get; set; }

        [JsonPropertyName("fedToKeycloakSyncMessage")]
        public string FedToKeycloakSyncMessage { get; set; }

        [JsonPropertyName("keycloakToFedSyncMessage")]
        public string KeycloakToFedSyncMessage { get; set; }
    }
}
