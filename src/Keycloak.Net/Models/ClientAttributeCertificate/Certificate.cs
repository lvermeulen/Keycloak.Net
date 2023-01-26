namespace Keycloak.Net.Models.ClientAttributeCertificate
{
    using Newtonsoft.Json;

    public class Certificate
    {
        [JsonProperty("certificate")]
        // ReSharper disable once InconsistentNaming
        public string _Certificate { get; set; }
        [JsonProperty("kid")]
        public string Kid { get; set; }
        [JsonProperty("privateKey")]
        public string PrivateKey { get; set; }
        [JsonProperty("publicKey")]
        public string PublicKey { get; set; }
    }
}
