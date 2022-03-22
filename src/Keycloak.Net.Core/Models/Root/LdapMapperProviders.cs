using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class LdapMapperProviders
    {
        [JsonProperty("msad-lds-user-account-control-mapper")]
        public HasOrder MsadLdsUserAccountControlMapper { get; set; }

        [JsonProperty("msad-user-account-control-mapper")]
        public HasOrder MsadUserAccountControlMapper { get; set; }

        [JsonProperty("group-ldap-mapper")]
        public HasOrder GroupLdapMapper { get; set; }

        [JsonProperty("user-attribute-ldap-mapper")]
        public HasOrder UserAttributeLdapMapper { get; set; }

        [JsonProperty("role-ldap-mapper")]
        public HasOrder RoleLdapMapper { get; set; }

        [JsonProperty("hardcoded-ldap-role-mapper")]
        public HasOrder HardcodedLdapRoleMapper { get; set; }

        [JsonProperty("full-name-ldap-mapper")]
        public HasOrder FullNameLdapMapper { get; set; }

        [JsonProperty("hardcoded-ldap-attribute-mapper")]
        public HasOrder HardcodedLdapAttributeMapper { get; set; }

        [JsonProperty("hardcoded-ldap-group-mapper")]
        public HasOrder HardcodedLdapGroupMapper { get; set; }
    }
}