namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class StorageProviders
    {
        [JsonPropertyName("ldap")]
        public HasOrder Ldap { get; set; }

        [JsonPropertyName("kerberos")]
        public HasOrder Kerberos { get; set; }
    }
}
