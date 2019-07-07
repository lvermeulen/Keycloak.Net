using System.Collections.Generic;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class ComponentTypes
    {
        [JsonProperty("org.keycloak.authentication.ClientAuthenticator")]
        public List<KeycloakAuthenticationAuthenticator> OrgKeycloakAuthenticationClientAuthenticator { get; set; }

        [JsonProperty("org.keycloak.services.clientregistration.policy.ClientRegistrationPolicy")]
        public List<KeycloakAuthenticationAuthenticator> OrgKeycloakServicesClientregistrationPolicyClientRegistrationPolicy { get; set; }

        [JsonProperty("org.keycloak.authentication.FormAction")]
        public List<KeycloakAuthenticationFormAction> OrgKeycloakAuthenticationFormAction { get; set; }

        [JsonProperty("org.keycloak.authentication.Authenticator")]
        public List<KeycloakAuthenticationAuthenticator> OrgKeycloakAuthenticationAuthenticator { get; set; }

        [JsonProperty("org.keycloak.storage.UserStorageProvider")]
        public List<KeycloakStorageUserStorageProvider> OrgKeycloakStorageUserStorageProvider { get; set; }

        [JsonProperty("org.keycloak.keys.KeyProvider")]
        public List<KeycloakAuthenticationFormAction> OrgKeycloakKeysKeyProvider { get; set; }

        [JsonProperty("org.keycloak.storage.ldap.mappers.LDAPStorageMapper")]
        public List<KeycloakStorageLdapMappersLdapStorageMapper> OrgKeycloakStorageLdapMappersLdapStorageMapper { get; set; }

        [JsonProperty("org.keycloak.authentication.FormAuthenticator")]
        public List<KeycloakAuthenticationAuthenticator> OrgKeycloakAuthenticationFormAuthenticator { get; set; }

        [JsonProperty("org.keycloak.protocol.ProtocolMapper")]
        public List<KeycloakAuthenticationAuthenticator> OrgKeycloakProtocolProtocolMapper { get; set; }

        [JsonProperty("org.keycloak.broker.provider.IdentityProviderMapper")]
        public List<KeycloakAuthenticationFormAction> OrgKeycloakBrokerProviderIdentityProviderMapper { get; set; }
    }
}