using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    public class KeysProviders
    {
        [JsonProperty("rsa")]
        public HasOrder Rsa { get; set; }

        [JsonProperty("java-keystore")]
        public HasOrder JavaKeystore { get; set; }

        [JsonProperty("rsa-generated")]
        public HasOrder RsaGenerated { get; set; }

        [JsonProperty("aes-generated")]
        public HasOrder AesGenerated { get; set; }

        [JsonProperty("ecdsa-generated")]
        public HasOrder EcdsaGenerated { get; set; }

        [JsonProperty("hmac-generated")]
        public HasOrder HmacGenerated { get; set; }
    }
}