namespace Keycloak.Net.Models.Root
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class ComponentTypes
    {
        [JsonPropertyName("org.keycloak.authentication.ClientAuthenticator")]
        public List<KeycloakAuthenticationAuthenticator> OrgKeycloakAuthenticationClientAuthenticator { get; set; }

        [JsonPropertyName("org.keycloak.services.clientregistration.policy.ClientRegistrationPolicy")]
        public List<KeycloakAuthenticationAuthenticator> OrgKeycloakServicesClientregistrationPolicyClientRegistrationPolicy { get; set; }

        [JsonPropertyName("org.keycloak.authentication.FormAction")]
        public List<KeycloakAuthenticationFormAction> OrgKeycloakAuthenticationFormAction { get; set; }

        [JsonPropertyName("org.keycloak.authentication.Authenticator")]
        public List<KeycloakAuthenticationAuthenticator> OrgKeycloakAuthenticationAuthenticator { get; set; }

        [JsonPropertyName("org.keycloak.storage.UserStorageProvider")]
        public List<KeycloakStorageUserStorageProvider> OrgKeycloakStorageUserStorageProvider { get; set; }

        [JsonPropertyName("org.keycloak.keys.KeyProvider")]
        public List<KeycloakAuthenticationFormAction> OrgKeycloakKeysKeyProvider { get; set; }

        [JsonPropertyName("org.keycloak.storage.ldap.mappers.LDAPStorageMapper")]
        public List<KeycloakStorageLdapMappersLdapStorageMapper> OrgKeycloakStorageLdapMappersLdapStorageMapper { get; set; }

        [JsonPropertyName("org.keycloak.authentication.FormAuthenticator")]
        public List<KeycloakAuthenticationAuthenticator> OrgKeycloakAuthenticationFormAuthenticator { get; set; }

        [JsonPropertyName("org.keycloak.protocol.ProtocolMapper")]
        public List<KeycloakAuthenticationAuthenticator> OrgKeycloakProtocolProtocolMapper { get; set; }

        [JsonPropertyName("org.keycloak.broker.provider.IdentityProviderMapper")]
        public List<KeycloakAuthenticationFormAction> OrgKeycloakBrokerProviderIdentityProviderMapper { get; set; }
    }
}
