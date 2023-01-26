namespace Keycloak.Net.Models.Root
{
    using Newtonsoft.Json;

    public class StorageProviders
    {
        [JsonProperty("ldap")]
        public HasOrder Ldap { get; set; }

        [JsonProperty("kerberos")]
        public HasOrder Kerberos { get; set; }
    }
}