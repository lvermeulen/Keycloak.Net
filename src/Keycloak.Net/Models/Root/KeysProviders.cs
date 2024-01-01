namespace Keycloak.Net.Models.Root
{
    using System.Text.Json.Serialization;

    public class KeysProviders
    {
        [JsonPropertyName("rsa")]
        public HasOrder Rsa { get; set; }

        [JsonPropertyName("java-keystore")]
        public HasOrder JavaKeystore { get; set; }

        [JsonPropertyName("rsa-generated")]
        public HasOrder RsaGenerated { get; set; }

        [JsonPropertyName("aes-generated")]
        public HasOrder AesGenerated { get; set; }

        [JsonPropertyName("ecdsa-generated")]
        public HasOrder EcdsaGenerated { get; set; }

        [JsonPropertyName("hmac-generated")]
        public HasOrder HmacGenerated { get; set; }
    }
}
