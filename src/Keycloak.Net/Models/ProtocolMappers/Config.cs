namespace Keycloak.Net.Models.ProtocolMappers
{
    using System.Text.Json.Serialization;

    public class Config
    {
        [JsonPropertyName("single")]
        public string Single { get; set; }
        [JsonPropertyName("attributenameformat")]
        public string AttributeNameFormat { get; set; }
        [JsonPropertyName("attributename")]
        public string AttributeName { get; set; }
        [JsonPropertyName("userinfotokenclaim")]
        public string UserInfoTokenClaim { get; set; }
        [JsonPropertyName("userattribute")]
        public string UserAttribute { get; set; }
        [JsonPropertyName("idtokenclaim")]
        public string IdTokenClaim { get; set; }
        [JsonPropertyName("accesstokenclaim")]
        public string AccessTokenClaim { get; set; }
        [JsonPropertyName("claimname")]
        public string ClaimName { get; set; }
        [JsonPropertyName("jsonTypelabel")]
        public string JsonTypelabel { get; set; }
        [JsonPropertyName("userattributeformatted")]
        public string UserAttributeFormatted { get; set; }
        [JsonPropertyName("userattributecountry")]
        public string UserAttributeCountry { get; set; }
        [JsonPropertyName("userattributepostal_code")]
        public string UserAttributePostalCode { get; set; }
        [JsonPropertyName("userattributestreet")]
        public string UserAttributeStreet { get; set; }
        [JsonPropertyName("userattributeregion")]
        public string UserAttributeRegion { get; set; }
        [JsonPropertyName("userattributelocality")]
        public string UserAttributeLocality { get; set; }
        [JsonPropertyName("multivalued")]
        public string Multivalued { get; set; }
    }
}
