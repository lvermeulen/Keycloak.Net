using Newtonsoft.Json;

namespace Keycloak.Net.Models.ClientAttributeCertificate
{
    public class KeyStoreConfig
    {
        [JsonProperty("format")]
        public string Format { get; set; }
        [JsonProperty("keyAlias")]
        public string KeyAlias { get; set; }
        [JsonProperty("keyPassword")]
        public string KeyPassword { get; set; }
        [JsonProperty("realmAlias")]
        public string RealmAlias { get; set; }
        [JsonProperty("realmCertificate")]
        public string RealmCertificate { get; set; }
        [JsonProperty("storePassword")]
        public string StorePassword { get; set; }
    }
}
