namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class LdapMapperProviders
    {
        [JsonPropertyName("msad-lds-user-account-control-mapper")]
        public HasOrder MsadLdsUserAccountControlMapper { get; set; }

        [JsonPropertyName("msad-user-account-control-mapper")]
        public HasOrder MsadUserAccountControlMapper { get; set; }

        [JsonPropertyName("group-ldap-mapper")]
        public HasOrder GroupLdapMapper { get; set; }

        [JsonPropertyName("user-attribute-ldap-mapper")]
        public HasOrder UserAttributeLdapMapper { get; set; }

        [JsonPropertyName("role-ldap-mapper")]
        public HasOrder RoleLdapMapper { get; set; }

        [JsonPropertyName("hardcoded-ldap-role-mapper")]
        public HasOrder HardcodedLdapRoleMapper { get; set; }

        [JsonPropertyName("full-name-ldap-mapper")]
        public HasOrder FullNameLdapMapper { get; set; }

        [JsonPropertyName("hardcoded-ldap-attribute-mapper")]
        public HasOrder HardcodedLdapAttributeMapper { get; set; }

        [JsonPropertyName("hardcoded-ldap-group-mapper")]
        public HasOrder HardcodedLdapGroupMapper { get; set; }
    }
}
