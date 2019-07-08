using Newtonsoft.Json;

namespace Keycloak.Net.Models.ProtocolMappers
{
    public class Config
    {
        [JsonProperty("single")]
        public string Single { get; set; }
        [JsonProperty("attributenameformat")]
        public string AttributeNameFormat { get; set; }
        [JsonProperty("attributename")]
        public string AttributeName { get; set; }
        [JsonProperty("userinfotokenclaim")]
        public string UserInfoTokenClaim { get; set; }
        [JsonProperty("userattribute")]
        public string UserAttribute { get; set; }
        [JsonProperty("idtokenclaim")]
        public string IdTokenClaim { get; set; }
        [JsonProperty("accesstokenclaim")]
        public string AccessTokenClaim { get; set; }
        [JsonProperty("claimname")]
        public string ClaimName { get; set; }
        [JsonProperty("jsonTypelabel")]
        public string JsonTypelabel { get; set; }
        [JsonProperty("userattributeformatted")]
        public string UserAttributeFormatted { get; set; }
        [JsonProperty("userattributecountry")]
        public string UserAttributeCountry { get; set; }
        [JsonProperty("userattributepostal_code")]
        public string UserAttributePostalCode { get; set; }
        [JsonProperty("userattributestreet")]
        public string UserAttributeStreet { get; set; }
        [JsonProperty("userattributeregion")]
        public string UserAttributeRegion { get; set; }
        [JsonProperty("userattributelocality")]
        public string UserAttributeLocality { get; set; }
        [JsonProperty("multivalued")]
        public string Multivalued { get; set; }
    }
}