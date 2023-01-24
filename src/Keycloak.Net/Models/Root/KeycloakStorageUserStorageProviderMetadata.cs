namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class KeycloakStorageUserStorageProviderMetadata
    {
        [JsonProperty("synchronizable")]
        public bool? Synchronizable { get; set; }
    }
}